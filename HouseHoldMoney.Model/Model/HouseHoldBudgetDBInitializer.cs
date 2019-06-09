using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseHoldMoney.Model
{
//    public class HouseHoldBudgetDBInitializer : DropCreateDatabaseIfModelChanges<HouseHoldContext>
//    {
//        protected override void Seed(HouseHoldContext context)
//        {
//            IList<Payment> defaultStandards = new List<Payment>();

//            defaultStandards.Add(new Payment() { ID = Guid.NewGuid(), TermOfPayment = ThermOfPayment.MONTHLY, Jan = true, Feb = true, Mar = true, Apr = true, May = true, Jun = true, Jul = true, Aug = true, Sep = true, Oct = true, Nov = true, Dec = true });
//            defaultStandards.Add(new Payment() { ID = Guid.NewGuid(), TermOfPayment = ThermOfPayment._2_MONTHLY, Jan = true, Feb = false, Mar = true, Apr = false, May = true, Jun = false, Jul = true, Aug = false, Sep = true, Oct = false, Nov = true, Dec = false });
//            defaultStandards.Add(new Payment() { ID = Guid.NewGuid(), TermOfPayment = ThermOfPayment._2_MONTHLY, Jan = false, Feb = true, Mar = false, Apr = true, May = false, Jun = true, Jul = false, Aug = true, Sep = false, Oct = true, Nov = false, Dec = true });
//            defaultStandards.Add(new Payment() { ID = Guid.NewGuid(), TermOfPayment = ThermOfPayment.QUARTERLY, Jan = true, Feb = false, Mar = false, Apr = true, May = false, Jun = false, Jul = true, Aug = false, Sep = false, Oct = true, Nov = false, Dec = false });
//            defaultStandards.Add(new Payment() { ID = Guid.NewGuid(), TermOfPayment = ThermOfPayment.QUARTERLY, Jan = false, Feb = true, Mar = false, Apr = false, May = true, Jun = false, Jul = false, Aug = true, Sep = false, Oct = false, Nov = true, Dec = false });
//            defaultStandards.Add(new Payment() { ID = Guid.NewGuid(), TermOfPayment = ThermOfPayment.QUARTERLY, Jan = false, Feb = false, Mar = true, Apr = false, May = false, Jun = true, Jul = false, Aug = false, Sep = true, Oct = false, Nov = false, Dec = true });

//            defaultStandards.Add(new Payment() { ID = Guid.NewGuid(), TermOfPayment = ThermOfPayment.SEMI_ANNUALLY, Jan = true, Feb = false, Mar = false, Apr = false, May = false, Jun = false, Jul = true, Aug = false, Sep = false, Oct = false, Nov = false, Dec = false });
//            defaultStandards.Add(new Payment() { ID = Guid.NewGuid(), TermOfPayment = ThermOfPayment.SEMI_ANNUALLY, Jan = false, Feb = true, Mar = false, Apr = false, May = false, Jun = false, Jul = false, Aug = true, Sep = false, Oct = false, Nov = false, Dec = false });
//            defaultStandards.Add(new Payment() { ID = Guid.NewGuid(), TermOfPayment = ThermOfPayment.SEMI_ANNUALLY, Jan = false, Feb = false, Mar = true, Apr = false, May = false, Jun = false, Jul = false, Aug = false, Sep = true, Oct = false, Nov = false, Dec = false });
//            defaultStandards.Add(new Payment() { ID = Guid.NewGuid(), TermOfPayment = ThermOfPayment.SEMI_ANNUALLY, Jan = false, Feb = false, Mar = false, Apr = true, May = false, Jun = false, Jul = false, Aug = false, Sep = false, Oct = true, Nov = false, Dec = false });
//            defaultStandards.Add(new Payment() { ID = Guid.NewGuid(), TermOfPayment = ThermOfPayment.SEMI_ANNUALLY, Jan = false, Feb = false, Mar = false, Apr = false, May = true, Jun = false, Jul = false, Aug = false, Sep = false, Oct = false, Nov = true, Dec = false });
//            defaultStandards.Add(new Payment() { ID = Guid.NewGuid(), TermOfPayment = ThermOfPayment.SEMI_ANNUALLY, Jan = false, Feb = false, Mar = false, Apr = false, May = false, Jun = true, Jul = false, Aug = false, Sep = false, Oct = false, Nov = false, Dec = true });

//            defaultStandards.Add( new Payment() { ID = Guid.NewGuid(), TermOfPayment = ThermOfPayment.ANNUALLY, Jan = true, Feb = false, Mar = false, Apr = false, May = false, Jun = false, Jul = true, Aug = false, Sep = false, Oct = false, Nov = false, Dec = false });
//            defaultStandards.Add( new Payment() { ID = Guid.NewGuid(), TermOfPayment = ThermOfPayment.ANNUALLY, Jan = false, Feb = true, Mar = false, Apr = false, May = false, Jun = false, Jul = false, Aug = true, Sep = false, Oct = false, Nov = false, Dec = false });
//            defaultStandards.Add( new Payment() { ID = Guid.NewGuid(), TermOfPayment = ThermOfPayment.ANNUALLY, Jan = false, Feb = false, Mar = true, Apr = false, May = false, Jun = false, Jul = false, Aug = false, Sep = true, Oct = false, Nov = false, Dec = false });
//            defaultStandards.Add( new Payment() { ID = Guid.NewGuid(), TermOfPayment = ThermOfPayment.ANNUALLY, Jan = false, Feb = false, Mar = false, Apr = true, May = false, Jun = false, Jul = false, Aug = false, Sep = false, Oct = true, Nov = false, Dec = false });
//            defaultStandards.Add( new Payment() { ID = Guid.NewGuid(), TermOfPayment = ThermOfPayment.ANNUALLY, Jan = false, Feb = false, Mar = false, Apr = false, May = true, Jun = false, Jul = false, Aug = false, Sep = false, Oct = false, Nov = true, Dec = false });
//            defaultStandards.Add( new Payment() { ID = Guid.NewGuid(), TermOfPayment = ThermOfPayment.ANNUALLY, Jan = false, Feb = false, Mar = false, Apr = false, May = false, Jun = true, Jul = false, Aug = false, Sep = false, Oct = false, Nov = false, Dec = true });
//            defaultStandards.Add( new Payment() { ID = Guid.NewGuid(), TermOfPayment = ThermOfPayment.ANNUALLY, Jan = true, Feb = false, Mar = false, Apr = false, May = false, Jun = false, Jul = true, Aug = false, Sep = false, Oct = false, Nov = false, Dec = false });
//            defaultStandards.Add( new Payment() { ID = Guid.NewGuid(), TermOfPayment = ThermOfPayment.ANNUALLY, Jan = false, Feb = true, Mar = false, Apr = false, May = false, Jun = false, Jul = false, Aug = true, Sep = false, Oct = false, Nov = false, Dec = false });
//            defaultStandards.Add( new Payment() { ID = Guid.NewGuid(), TermOfPayment = ThermOfPayment.ANNUALLY, Jan = false, Feb = false, Mar = true, Apr = false, May = false, Jun = false, Jul = false, Aug = false, Sep = true, Oct = false, Nov = false, Dec = false });
//            defaultStandards.Add( new Payment() { ID = Guid.NewGuid(), TermOfPayment = ThermOfPayment.ANNUALLY, Jan = false, Feb = false, Mar = false, Apr = true, May = false, Jun = false, Jul = false, Aug = false, Sep = false, Oct = true, Nov = false, Dec = false });
//            defaultStandards.Add( new Payment() { ID = Guid.NewGuid(), TermOfPayment = ThermOfPayment.ANNUALLY, Jan = false, Feb = false, Mar = false, Apr = false, May = true, Jun = false, Jul = false, Aug = false, Sep = false, Oct = false, Nov = true, Dec = false });
//            defaultStandards.Add( new Payment() { ID = Guid.NewGuid(), TermOfPayment = ThermOfPayment.ANNUALLY, Jan = false, Feb = false, Mar = false, Apr = false, May = false, Jun = true, Jul = false, Aug = false, Sep = false, Oct = false, Nov = false, Dec = true });


//            context.Payments.AddRange(defaultStandards);

//            base.Seed(context);
//        }
//    }
}
