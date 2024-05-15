using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constans
{
    public class Messages
    {
        public static string CarAdded = "Car is Added";
        public static string CarNameInvalid = "Car Name is Invalid";
        public static string CustomerAdded = "Customer is Added";

        public static string CustomerNameInvalid = "Customer Name is Invalid";
        public static string CustomerListed = "Customer is Added";
        public static string MaintenanceTime = "System are Maintenance";


        public static string RentalCancel= "This car cannot be rented at the moment";
        public static string RentalListed = "Rental is Invalid";
        public static string RentalDeleted = "Rental is deleted";


        public static string CarIsNotAvailable="Car is Not Available";
        internal static string RentalUpdated="Rental Updated";

        internal static string BrandAdded = "Brand is added";
        internal static string BrandDeleted = "Brand is deleted";
        internal static string Brandlisted = "Brand is listed";
        internal static string BrandUpdated="Brands is Updated";

        internal static string ColorAdded="Color is Added";
        internal static string ColorDeleted="Color is Deleted";
        internal static string ColorUpdated="Color is Updated";
        internal static string colorListed="Colors are Listed";
        internal static string PasswordInvalid;
        internal static string UserAdded;
        internal static string UserListed;
        internal static string CarDeleted;
        internal static string CarUpdated;
        internal static string CarImagesAdded;
    }
}
