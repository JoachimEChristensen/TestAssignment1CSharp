using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    public class MinMax
    {

        public int[] FindMinMax(String[] args)
        {

            int mi, ma;
            if (args.Length < 2)
            {
                Console.Write("Invalid number of arguments given - must be two or more");
                return new int[] { };
            }
            else
            {
                try
                {
                    mi = ma = Int32.Parse(args[0]);

                    for (int i = 1; i < args.Length; i++)
                    {
                        int obs = Int32.Parse(args[i]);
                        if (obs > ma)
                        {
                            ma = obs;
                        }
                        else
                        {
                            if (obs < mi)
                            {
                                mi = obs;
                            }
                        }
                    }
                    Console.Write("Min : " + mi + " Max : " + ma);
                    return new int[] { mi, ma };

                }
                catch (Exception e)
                {
                    Console.Write("Input must be numbers.");
                    throw new Exception(e.ToString());
                }
            }

        }
    }
}
