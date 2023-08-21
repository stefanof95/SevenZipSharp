using System;

namespace SevenZip
{
    /// <summary>
    /// Exception thrown when compression is canceled.
    /// </summary>
    public class SevenZipCompressionCanceledException: Exception
    {
        /// <summary>
        /// Message of exception.
        /// </summary>
        public override string Message => "Canceled";
    }
}