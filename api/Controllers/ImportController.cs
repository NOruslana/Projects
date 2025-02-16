using api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImportController : ControllerBase
    {
        private readonly ProjectDbContext _context;

        public ImportController(ProjectDbContext context)
        {
            _context = context;
        }

        [HttpPost("departments")]
        public async Task<IActionResult> UploadDepartments(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("Файл не загружен!");

            Dictionary<string, int> departmentMap = new(); // Для хранения ID отделов
            Depatment currentDepartment = null;

            using (var reader = new StreamReader(file.OpenReadStream()))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine()?.Trim();
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    if (char.IsDigit(line[0])) // Отдел
                    {
                        int level = line.Count(c => c == '.') + 1;
                        string deptName = line.Split(' ', 2)[1];
                        int? parentId = null;

                        if (level > 1)
                        {
                            string parentKey = line.Substring(0, line.LastIndexOf('.'));
                            if (departmentMap.ContainsKey(parentKey))
                                parentId = departmentMap[parentKey];
                        }
                        currentDepartment = new Depatment { DepatmentName = deptName, Parent = parentId, Level = level };
                        _context.Depatments.Add(currentDepartment);
                        await _context.SaveChangesAsync();

                        departmentMap[line.Split(' ')[0]] = currentDepartment.DepatmentId;
                    }
                    else if (currentDepartment != null) // Должности и сотрудники
                    {
                        var parts = line.Split('\t');
                        if (parts.Length == 6)
                        {
                            string positionName = parts[0].Trim();
                            string employeeName = parts[1].Trim();
                            DateOnly birthDate = DateOnly.Parse(parts[2].Trim());
                            string email = parts[5].Trim();
                            string phone = parts[3].Trim();
                            string address = parts[4].Trim();

                            var position = await _context.Positions
                                .FirstOrDefaultAsync(p => p.PositionName == positionName);

                            if (position == null)
                            {
                                position = new Position { PositionName = positionName };
                                _context.Positions.Add(position);
                                await _context.SaveChangesAsync();
                            }

                            var employee = new Worker
                            {
                                WorkerName = employeeName,
                                Birthday = birthDate,
                                WorkPhone = phone,
                                OfficeRoom = address,
                                Email = email,
                                Depatment = currentDepartment,
                                Position = position
                            };

                            _context.Workers.Add(employee);
                            await _context.SaveChangesAsync();
                        }
                    }
                }
            }

            return Ok(new { message = "Данные успешно загружены!" });
        }
    }
}
