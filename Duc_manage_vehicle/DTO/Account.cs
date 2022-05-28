using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duc_manage_vehicle.DTO
{
    internal class Account
    {
        public string user_id { get; set; }
        public string password { get; set; }
        public string? fullname { get; set; }
        public string? user_identity_card_num { get; set; }
        public string? user_phone { get; set; }
    }
}
