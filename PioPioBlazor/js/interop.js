window.clipboardCopy = {
    copyText: function (text) {
        navigator.clipboard.writeText(text).then(function () {
            alert("Copied to clipboard!");
        })
            .catch(function (error) {
                alert(error);
            });
    }
};

window.tagSelectorComponent = {
    getValue: function (element) {
        return element.value;
    },
    setValue: function (element, value) {
        element.value = value;
    },
    blur: function (element) {
        element.blur();
    }
};