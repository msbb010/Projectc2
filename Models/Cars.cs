

using Microsoft.EntityFrameworkCore;

namespace Cars{
    public class CarsContext: DbContext{
        public DbSet<Car> Cars { get; set; }
    }

    public class Car {}
}