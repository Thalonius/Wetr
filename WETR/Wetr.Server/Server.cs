using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wetr.Server {

    public static class ServerHelper {
        public static bool NotIn<T>(this T x, params T[] set) {
            return !set.Contains(x);
        }
        public static bool In<T>(this T x, params T[] set) {
            return set.Contains(x);
        }
    }

    public class Server
    {
    }
}
