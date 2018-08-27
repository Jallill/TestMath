using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace TestMaths {
    static class RandomIntGenerator {
        private static Int64 GenerateRNGNewInstance(int size) {
            using (var generator = RandomNumberGenerator.Create()) {
                var bytes = new byte[size];
                generator.GetBytes(bytes);
                return BayToInt64(bytes, 0);
            }
        }

        private static Int64 BayToInt64(byte[] bytes, int index) {
            return BitConverter.ToInt64(bytes, index);
            //return value = value > 0 ? value : value * -1;
        }

        public static Int64 RNGbyCant(int cant, bool onlyPositive) {
            return GenerateRNGNewInstance(8) % (Int64)Math.Pow(10,cant);
        }

        //public static Int64 RNGbyRange(Int64 minVal, Int64 maxVal, bool onlyPositive) {

        //}

        public static Int64 RNG(bool onlyPositive) {
            Int64 num = (Int64)(GenerateRNGNewInstance(8)% 100)/5;
            num = num > 19 ? num = 19 : num;
            return GenerateRNGNewInstance(8) % (Int64)Math.Pow(10, num);
        }


    }
}
