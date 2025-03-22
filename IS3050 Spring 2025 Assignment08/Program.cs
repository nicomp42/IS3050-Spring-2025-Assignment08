/*
 * IS3050 Spring 2025 Assignment 08
 * Created by Bill Nicholson
 * Edited by
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace IS3050_Spring_2025_Assignment08
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        /// <summary>
        /// Validate a password.
        /// </summary>
        /// <param name="password">The string to validate</param>
        /// <returns>True if valid, False otherwise</returns>
        static bool ValidatePassword(String password)
        {
            Boolean status = true;     // Assume it's valid

            if (password == null || password.Length < 10) {
                return false; // Must be at least 10 characters long
            }

            bool hasSpecial = false;
            bool hasLower = false;
            bool hasUpper = false;

            foreach (char c in password) {
                if ("~!@#$%^&*()".Contains(c)) {
                    hasSpecial = true;
                }
                else if (char.IsLower(c)) {
                    hasLower = true;
                }
                else if (char.IsUpper(c)) {
                    hasUpper = true;
                }
            }

            if (!hasSpecial || !hasLower || !hasUpper) {
                status = false;
            }
            return status;
        }
    }
}
