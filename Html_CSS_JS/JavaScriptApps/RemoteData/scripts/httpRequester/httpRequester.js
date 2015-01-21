define(['jquery'], function ($) {
    var httpRequester = (function () {
        function getPromise(requestURL, header, data) {
            var type, data;
            if (data) {
                type = 'POST';
                data = JSON.stringify(data)
            } else {
                if (header) {
                    type = 'GET';
                    data = {};
                }
                else {
                    type = 'POST';
                    data = {_method: 'delete'};
                }
            }
            return $.ajax({
                beforeSend: function (xhrObj) {
                    if (header) {
                        xhrObj.setRequestHeader("Content-Type", header);
                        xhrObj.setRequestHeader("Accept", header);
                    }
                },
                data: data,
                url: requestURL,
                type: type
            });

        }

        function httpRequester() {

        }

        httpRequester.getJSON = function (requestURL, header) {
            return getPromise(requestURL, header);
        };

        httpRequester.postJSON = function (requestURL, header, data) {
            return getPromise(requestURL, header, data);
        };

        return httpRequester;
    }());
    return httpRequester;
});

