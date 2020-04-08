using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace CookingTerminalMain.Security
{
    public interface IHavePassword
    {
        /// <summary>
        /// The secure password to get
        /// </summary>
        public SecureString SecurePassword { get; }

    }
}
