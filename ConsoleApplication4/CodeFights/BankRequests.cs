using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4.CodeFights
{
    public class BankRequests
    {
        int[] bankRequests(int[] accounts, string[] requests)
        {
            //TODO: Handle int max bounds
            if (accounts.Length == 0 || requests.Length == 0)
            {
                return accounts;
            }
            for (int i = 0; i < requests.Length; i++)
            {
                string[] tokens = requests[i].Split(' ');
                string req = tokens[0];
                if (tokens.Length < 3)
                {
                    return new int[] { -(i + 1) };
                }
                //Console.WriteLine(tokens.Length);
                int s1 = Convert.ToInt32(tokens[1]);
                int s2 = Convert.ToInt32(tokens[2]);
                bool s = true;
                switch (req)
                {
                    case "deposit":
                        s = Deposit(accounts, s1 - 1, s2);
                        break;
                    case "withdraw":
                        s = Withdraw(accounts, s1 - 1, s2);
                        break;
                    case "transfer":
                        if (tokens.Length < 4)
                        {
                            return new int[] { -(i + 1) };
                        }
                        s = Transfer(accounts, s1 - 1, s2 - 1, Convert.ToInt32(tokens[3]));
                        break;
                }
                if (!s)
                {
                    return new int[] { -(i + 1) };
                }
                //Console.WriteLine(string.Join(" , ",accounts));
            }
            return accounts;
        }

        bool Transfer(int[] acc, int f, int t, int sum)
        {
            if (f < 0 || t < 0 || acc.Length <= f || acc.Length <= t || f == t)
            {
                return false;
            }
            if (sum < 0)
            {
                return false;
            }
            int left = acc[f] - sum;
            int right = acc[t] + sum;
            if (left < 0 || right < 0)
            {
                return false;
            }
            else
            {
                acc[f] = left;
                acc[t] = right;
                return true;
            }
        }

        bool Deposit(int[] acc, int f, int sum)
        {
            if (f < 0 || acc.Length <= f)
            {
                return false;
            }
            if (sum < 0)
            {
                return false;
            }
            int left = acc[f] + sum;

            if (left < 0)
            {
                return false;
            }
            else
            {
                acc[f] = left;
                return true;
            }
        }

        bool Withdraw(int[] acc, int f, int sum)
        {
            if (f < 0 || acc.Length <= f)
            {
                return false;
            }
            if (sum < 0)
            {
                return false;
            }
            int left = acc[f] - sum;

            if (left < 0)
            {
                return false;
            }
            else
            {
                acc[f] = left;
                return true;
            }
        }
    }
}
