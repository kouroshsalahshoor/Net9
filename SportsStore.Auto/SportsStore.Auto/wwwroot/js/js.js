﻿window.ShowToastr = (type, message) => {
    if (type === "success") {
        toastr.success(message);
    }
    if (type === "error") {
        toastr.error(message);
    }
    if (type === "warning") {
        toastr.error(message);
    }
    if (type === "info") {
        toastr.error(message);
    }
}