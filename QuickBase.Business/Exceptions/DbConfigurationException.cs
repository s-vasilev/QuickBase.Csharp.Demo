using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBase.Business.Exceptions
{
    /// <summary>Custom exception for Db configuration issues.</summary>
    public class DbConfigurationException : Exception
    {
        /// <summary>Initializes a new instance of the <see cref="DbConfigurationException" /> class.</summary>
        public DbConfigurationException()
        {
        }
    }
}
