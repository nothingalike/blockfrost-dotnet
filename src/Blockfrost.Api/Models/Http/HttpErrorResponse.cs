﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Blockfrost.Api
{
    public partial class BadRequestResponse : HttpErrorResponse
    {
    }

    public partial class ForbiddenResponse : HttpErrorResponse
    {
    }

    public abstract class HttpErrorResponse
    {
        [JsonPropertyName("error")]
        [Required(AllowEmptyStrings = true)]
        public string Error { get; set; }

        [JsonPropertyName("message")]
        [Required(AllowEmptyStrings = true)]
        public string Message { get; set; }

        [JsonPropertyName("status_code")]
        public int Status_code { get; set; }
    }

    public partial class InternalServerErrorResponse : HttpErrorResponse
    {
    }

    public partial class NotFoundResponse : HttpErrorResponse
    {
    }

    public partial class TooManyRequestsResponse : HttpErrorResponse
    {
    }

    public partial class UnsupportedMediaTypeResponse : HttpErrorResponse
    {
    }
}
