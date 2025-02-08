﻿using Microsoft.JSInterop;

namespace SportsStore.Auto.Client.Utilities
{
    public static class IJsRuntimeExtensions
    {
        public static async Task ToastrSuccess(this IJSRuntime js, string message)
        {
            await js.InvokeVoidAsync("ShowToastr", "success", message);
        }
        public static async Task ToastrError(this IJSRuntime js, string message)
        {
            await js.InvokeVoidAsync("ShowToastr", "error", message);
        }
        public static async Task ToastrWarning(this IJSRuntime js, string message)
        {
            await js.InvokeVoidAsync("ShowToastr", "warning", message);
        }
        public static async Task ToastrInfo(this IJSRuntime js, string message)
        {
            await js.InvokeVoidAsync("ShowToastr", "info", message);
        }
    }
}
