namespace netcore_webapi_practice.Models
{
    public class ApiResponse<T>
    {
        public bool Success { get; set; }
        public T? Data { get; set; }
        public string Message { get; set; }
        public int HttpStatus { get; set; }

        public ApiResponse(bool success, T data, string message, int httpStatus)
        {
            Success = success;
            Data = data;
            Message = message;
            HttpStatus = httpStatus;
        }
    }
}
