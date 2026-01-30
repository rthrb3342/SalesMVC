using SalesWebMVC.Models;
using SalesWebMVC.Models.Enums;

namespace SalesWebMVC.Data
{
    public class SeedingService
    {
        private SalesWebMVCContext _context;

        public SeedingService(SalesWebMVCContext context)
        {
            _context = context;
        }


        //public void Seed()
        //{
        //    // Garante que só roda uma vez
        //    if (_context.Department.Any() ||
        //        _context.Seller.Any() ||
        //        _context.SalesRecord.Any())
        //    {
        //        return;
        //    }

        //    // --------------------
        //    // Departments
        //    // --------------------
        //    var d1 = new Department { Name = "Computers" };
        //    var d2 = new Department { Name = "Electronics" };
        //    var d3 = new Department { Name = "Fashion" };
        //    var d4 = new Department { Name = "Books" };


        //    // --------------------
        //    // Sellers
        //    // --------------------
        //    var s1 = new Seller
        //    {
        //        Name = "Bob Brown",
        //        Email = "jenjarjostini@gmail.com",
        //        BirthDate = new DateTime(1998, 4, 21),
        //        BaseSalary = 1000.0,
        //        Department = d1
        //    };

        //    var s2 = new Seller
        //    {
        //        Name = "Maria Green",
        //        Email = "maria@gmail.com",
        //        BirthDate = new DateTime(1979, 12, 31),
        //        BaseSalary = 3500.0,
        //        Department = d2
        //    };

        //    var s3 = new Seller
        //    {
        //        Name = "Alex Grey",
        //        Email = "alex@gmail.com",
        //        BirthDate = new DateTime(1988, 1, 15),
        //        BaseSalary = 2200.0,
        //        Department = d1
        //    };

        //    var s4 = new Seller
        //    {
        //        Name = "Martha Red",
        //        Email = "martha@gmail.com",
        //        BirthDate = new DateTime(1993, 11, 30),
        //        BaseSalary = 3000.0,
        //        Department = d4
        //    };

        //    var s5 = new Seller
        //    {
        //        Name = "Donald Blue",
        //        Email = "donald@gmail.com",
        //        BirthDate = new DateTime(2000, 1, 9),
        //        BaseSalary = 4000.0,
        //        Department = d3
        //    };

        //    var s6 = new Seller
        //    {
        //        Name = "Alex Pink",
        //        Email = "bob@gmail.com",
        //        BirthDate = new DateTime(1997, 3, 4),
        //        BaseSalary = 3000.0,
        //        Department = d2
        //    };


        //    // --------------------
        //    // Sales Records
        //    // --------------------
        //    var sales = new List<SalesRecord>
        //{
        //    new SalesRecord
        //    {
        //        Date = new DateTime(2023, 9, 25),
        //        Amount = 11000.0,
        //        Status = SalesStatus.Billed,
        //        Seller = s1
        //    },
        //    new SalesRecord
        //    {
        //        Date = new DateTime(2023, 9, 4),
        //        Amount = 7000.0,
        //        Status = SalesStatus.Billed,
        //        Seller = s5
        //    },
        //    new SalesRecord
        //    {
        //        Date = new DateTime(2023, 9, 13),
        //        Amount = 4000.0,
        //        Status = SalesStatus.Canceled,
        //        Seller = s4
        //    },
        //    new SalesRecord
        //    {
        //        Date = new DateTime(2023, 9, 1),
        //        Amount = 8000.0,
        //        Status = SalesStatus.Billed,
        //        Seller = s1
        //    },
        //    new SalesRecord
        //    {
        //        Date = new DateTime(2023, 9, 21),
        //        Amount = 3000.0,
        //        Status = SalesStatus.Billed,
        //        Seller = s3
        //    },
        //    new SalesRecord
        //    {
        //        Date = new DateTime(2023, 9, 15),
        //        Amount = 2000.0,
        //        Status = SalesStatus.Billed,
        //        Seller = s1
        //    },
        //    new SalesRecord
        //    {
        //        Date = new DateTime(2023, 9, 28),
        //        Amount = 13000.0,
        //        Status = SalesStatus.Billed,
        //        Seller = s2
        //    },
        //    new SalesRecord
        //    {
        //        Date = new DateTime(2023, 9, 11),
        //        Amount = 4000.0,
        //        Status = SalesStatus.Billed,
        //        Seller = s4
        //    },
        //    new SalesRecord
        //    {
        //        Date = new DateTime(2023, 9, 14),
        //        Amount = 11000.0,
        //        Status = SalesStatus.Pending,
        //        Seller = s6
        //    },
        //    new SalesRecord
        //    {
        //        Date = new DateTime(2023, 9, 7),
        //        Amount = 9000.0,
        //        Status = SalesStatus.Billed,
        //        Seller = s6
        //    }
        //};

        //    // Departments
        //    _context.Department.AddRange(d1, d2, d3, d4);
        //    _context.SaveChanges();

        //    // Sellers
        //    _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
        //    _context.SaveChanges();
        //    // SalesRecords
        //    _context.SalesRecord.AddRange(sales);
        //    _context.SaveChanges();
        //}




        public void Seed()
        {
            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                Console.WriteLine("Não inseriu");
                return; // DB has been seeded
            }
            Console.WriteLine("Inseriu");
            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");
            _context.Department.AddRange(d1, d2, d3, d4);

            Seller s1 = new Seller(1, "Bob Brown", "jenjarjostini@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s2 = new Seller(2, "Maria Green", "maria@gmail.com", new DateTime(1979, 12, 31), 3500.0, d2);
            Seller s3 = new Seller(3, "Alex Grey", "alex@gmail.com", new DateTime(1988, 1, 15), 2200.0, d1);
            Seller s4 = new Seller(4, "Martha Red", "martha@gmail.com", new DateTime(1993, 11, 30), 3000.0, d4);
            Seller s5 = new Seller(5, "Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9), 4000.0, d3);
            Seller s6 = new Seller(6, "Alex Pink", "bob@gmail.com", new DateTime(1997, 3, 4), 3000.0, d2);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2023, 09, 25), 11000.0, SalesStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2023, 09, 4), 7000.0, SalesStatus.Billed, s5);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2023, 09, 13), 4000.0, SalesStatus.Canceled, s4);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2023, 09, 1), 8000.0, SalesStatus.Billed, s1);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2023, 09, 21), 3000.0, SalesStatus.Billed, s3);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2023, 09, 15), 2000.0, SalesStatus.Billed, s1);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2023, 09, 28), 13000.0, SalesStatus.Billed, s2);
            SalesRecord r8 = new SalesRecord(8, new DateTime(2023, 09, 11), 4000.0, SalesStatus.Billed, s4);
            SalesRecord r9 = new SalesRecord(9, new DateTime(2023, 09, 14), 11000.0, SalesStatus.Pending, s6);
            SalesRecord r10 = new SalesRecord(10, new DateTime(2023, 09, 7), 9000.0, SalesStatus.Billed, s6);
            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10);

            _context.SaveChanges();
        }
    }
}
