using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Core.DTOs
{
    public class CustomNoContentResponseDto
    {
        [JsonIgnore]
        public int StatusCode { get; set; }
        public List<string> Errors { get; set; }

        public static CustomNoContentResponseDto Success(int statusCode)
        {
            return new CustomNoContentResponseDto { StatusCode = statusCode};
        }

        public static CustomNoContentResponseDto Fail(int statusCode, List<string> errors)
        {
            return new CustomNoContentResponseDto { StatusCode = statusCode, Errors = errors };
        }

        public static CustomNoContentResponseDto Fail(int statusCode, string error)
        {
            return new CustomNoContentResponseDto { StatusCode = statusCode, Errors = new List<string> { error } };
        }
    }
}
