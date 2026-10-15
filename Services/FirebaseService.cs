using Microsoft.JSInterop;
using System.Text.Json;

namespace QOL_Upper_App_v3.Services
{
    public class FirebaseService
    {
        private readonly IJSRuntime _jsRuntime;

        public FirebaseService(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async Task SaveDataAsync<T>(string collection, string docId, T data)
        {
            var json = JsonSerializer.Serialize(data);
            await _jsRuntime.InvokeAsync<bool>("firebaseInterop.saveData", collection, docId, json);
        }

        public async Task<T?> GetDataAsync<T>(string collection, string docId)
        {
            var json = await _jsRuntime.InvokeAsync<string>("firebaseInterop.getData", collection, docId);
            if (string.IsNullOrEmpty(json)) return default;
            return JsonSerializer.Deserialize<T>(json);
        }
    }
}