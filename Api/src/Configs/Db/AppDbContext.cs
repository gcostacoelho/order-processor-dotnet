using Microsoft.EntityFrameworkCore;

namespace Api.src.Configs.Db;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{

}
