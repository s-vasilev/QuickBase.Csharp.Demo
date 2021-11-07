namespace QuickBase.API.ApiModels
{
    /// <summary>Error model.</summary>
    public class ErrorModel
    {
        /// <summary>Gets or sets the error message.</summary>
        /// <value>The error message.</value>
        public string Message { get; set; }

        /// <summary>Gets or sets the status code.</summary>
        /// <value>The status code.</value>
        public int StatusCode { get; set; }
    }
}
