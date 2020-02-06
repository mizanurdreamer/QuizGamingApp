using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGamingApp.Core.EnitityModel
{
    public class GameCoupon : Base
    {
        public string CouponTitle { get; set; }
        public decimal PrizeMoney { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
