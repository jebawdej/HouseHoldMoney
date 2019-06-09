using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseHoldMoney.Model
{
    public enum ThermOfPayment { MONTHLY, _2_MONTHLY, QUARTERLY, SEMI_ANNUALLY, ANNUALLY, CUSTOM }
    public class HouseHoldMoney
    {
        public Guid ID { get; set; }
        public string Organisation { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public bool Automatically { get; set; }

        public Payment Payment { get; set; }
    }
    public class Payment
    {
        public Guid ID { get; set; }
        public ThermOfPayment TermOfPayment { get; set; }
        public bool Jan { get; set; }
        public bool Feb { get; set; }
        public bool Mar { get; set; }
        public bool Apr { get; set; }
        public bool May { get; set; }
        public bool Jun { get; set; }
        public bool Jul { get; set; }
        public bool Aug { get; set; }
        public bool Sep { get; set; }
        public bool Oct { get; set; }
        public bool Nov { get; set; }
        public bool Dec { get; set; }
    }
    public class HouseHoldContext : DbContext
    {
        public DbSet<HouseHoldMoney> HouseHoldMoneys { get; set; }
        public DbSet<Payment> Payments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=HouseHoldMoney.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Payment>().HasData(
                new Payment() { ID = Guid.NewGuid(), TermOfPayment = ThermOfPayment.MONTHLY, Jan = true, Feb = true, Mar = true, Apr = true, May = true, Jun = true, Jul = true, Aug = true, Sep = true, Oct = true, Nov = true, Dec = true },
                new Payment() { ID = Guid.NewGuid(), TermOfPayment = ThermOfPayment._2_MONTHLY, Jan = true, Feb = false, Mar = true, Apr = false, May = true, Jun = false, Jul = true, Aug = false, Sep = true, Oct = false, Nov = true, Dec = false },
                new Payment() { ID = Guid.NewGuid(), TermOfPayment = ThermOfPayment._2_MONTHLY, Jan = false, Feb = true, Mar = false, Apr = true, May = false, Jun = true, Jul = false, Aug = true, Sep = false, Oct = true, Nov = false, Dec = true },
                new Payment() { ID = Guid.NewGuid(), TermOfPayment = ThermOfPayment.QUARTERLY, Jan = true, Feb = false, Mar = false, Apr = true, May = false, Jun = false, Jul = true, Aug = false, Sep = false, Oct = true, Nov = false, Dec = false },
                new Payment() { ID = Guid.NewGuid(), TermOfPayment = ThermOfPayment.QUARTERLY, Jan = false, Feb = true, Mar = false, Apr = false, May = true, Jun = false, Jul = false, Aug = true, Sep = false, Oct = false, Nov = true, Dec = false },
                new Payment() { ID = Guid.NewGuid(), TermOfPayment = ThermOfPayment.QUARTERLY, Jan = false, Feb = false, Mar = true, Apr = false, May = false, Jun = true, Jul = false, Aug = false, Sep = true, Oct = false, Nov = false, Dec = true },

                new Payment() { ID = Guid.NewGuid(), TermOfPayment = ThermOfPayment.SEMI_ANNUALLY, Jan = true, Feb = false, Mar = false, Apr = false, May = false, Jun = false, Jul = true, Aug = false, Sep = false, Oct = false, Nov = false, Dec = false },
                new Payment() { ID = Guid.NewGuid(), TermOfPayment = ThermOfPayment.SEMI_ANNUALLY, Jan = false, Feb = true, Mar = false, Apr = false, May = false, Jun = false, Jul = false, Aug = true, Sep = false, Oct = false, Nov = false, Dec = false },
                new Payment() { ID = Guid.NewGuid(), TermOfPayment = ThermOfPayment.SEMI_ANNUALLY, Jan = false, Feb = true, Mar = false, Apr = false, May = false, Jun = false, Jul = false, Aug = true, Sep = false, Oct = false, Nov = false, Dec = false },
                new Payment() { ID = Guid.NewGuid(), TermOfPayment = ThermOfPayment.SEMI_ANNUALLY, Jan = false, Feb = false, Mar = false, Apr = true, May = false, Jun = false, Jul = false, Aug = false, Sep = false, Oct = true, Nov = false, Dec = false },
                new Payment() { ID = Guid.NewGuid(), TermOfPayment = ThermOfPayment.SEMI_ANNUALLY, Jan = false, Feb = false, Mar = false, Apr = false, May = true, Jun = false, Jul = false, Aug = false, Sep = false, Oct = false, Nov = true, Dec = false },
                new Payment() { ID = Guid.NewGuid(), TermOfPayment = ThermOfPayment.SEMI_ANNUALLY, Jan = false, Feb = false, Mar = false, Apr = false, May = false, Jun = true, Jul = false, Aug = false, Sep = false, Oct = false, Nov = false, Dec = true },

                 new Payment() { ID = Guid.NewGuid(), TermOfPayment = ThermOfPayment.ANNUALLY, Jan = true, Feb = false, Mar = false, Apr = false, May = false, Jun = false, Jul = true, Aug = false, Sep = false, Oct = false, Nov = false, Dec = false },
                 new Payment() { ID = Guid.NewGuid(), TermOfPayment = ThermOfPayment.ANNUALLY, Jan = false, Feb = true, Mar = false, Apr = false, May = false, Jun = false, Jul = false, Aug = true, Sep = false, Oct = false, Nov = false, Dec = false },
                 new Payment() { ID = Guid.NewGuid(), TermOfPayment = ThermOfPayment.ANNUALLY, Jan = false, Feb = false, Mar = true, Apr = false, May = false, Jun = false, Jul = false, Aug = false, Sep = true, Oct = false, Nov = false, Dec = false },
                 new Payment() { ID = Guid.NewGuid(), TermOfPayment = ThermOfPayment.ANNUALLY, Jan = false, Feb = false, Mar = false, Apr = true, May = false, Jun = false, Jul = false, Aug = false, Sep = false, Oct = true, Nov = false, Dec = false },
                 new Payment() { ID = Guid.NewGuid(), TermOfPayment = ThermOfPayment.ANNUALLY, Jan = false, Feb = false, Mar = false, Apr = false, May = true, Jun = false, Jul = false, Aug = false, Sep = false, Oct = false, Nov = true, Dec = false },
                 new Payment() { ID = Guid.NewGuid(), TermOfPayment = ThermOfPayment.ANNUALLY, Jan = false, Feb = false, Mar = false, Apr = false, May = false, Jun = true, Jul = false, Aug = false, Sep = false, Oct = false, Nov = false, Dec = true },
                 new Payment() { ID = Guid.NewGuid(), TermOfPayment = ThermOfPayment.ANNUALLY, Jan = true, Feb = false, Mar = false, Apr = false, May = false, Jun = false, Jul = true, Aug = false, Sep = false, Oct = false, Nov = false, Dec = false },
                 new Payment() { ID = Guid.NewGuid(), TermOfPayment = ThermOfPayment.ANNUALLY, Jan = false, Feb = true, Mar = false, Apr = false, May = false, Jun = false, Jul = false, Aug = true, Sep = false, Oct = false, Nov = false, Dec = false },
                 new Payment() { ID = Guid.NewGuid(), TermOfPayment = ThermOfPayment.ANNUALLY, Jan = false, Feb = false, Mar = true, Apr = false, May = false, Jun = false, Jul = false, Aug = false, Sep = true, Oct = false, Nov = false, Dec = false },
                 new Payment() { ID = Guid.NewGuid(), TermOfPayment = ThermOfPayment.ANNUALLY, Jan = false, Feb = false, Mar = false, Apr = true, May = false, Jun = false, Jul = false, Aug = false, Sep = false, Oct = true, Nov = false, Dec = false },
                 new Payment() { ID = Guid.NewGuid(), TermOfPayment = ThermOfPayment.ANNUALLY, Jan = false, Feb = false, Mar = false, Apr = false, May = true, Jun = false, Jul = false, Aug = false, Sep = false, Oct = false, Nov = true, Dec = false },
                 new Payment() { ID = Guid.NewGuid(), TermOfPayment = ThermOfPayment.ANNUALLY, Jan = false, Feb = false, Mar = false, Apr = false, May = false, Jun = true, Jul = false, Aug = false, Sep = false, Oct = false, Nov = false, Dec = true }
                 );
        }
    }
}