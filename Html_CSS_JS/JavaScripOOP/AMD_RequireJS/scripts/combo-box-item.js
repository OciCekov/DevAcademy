﻿define(['libs/jquery', 'libs/handlebars'], function () {
    var ComboBoxItem = (function () {
        function ComboBoxItem(item) {
            this._content = item || [];
        }

        ComboBoxItem.prototype.render = function (htmlTemplate) {
            var compiledTemplate = Handlebars.compile(htmlTemplate);
            var $item = $('<div>')
                .addClass('combo-box-item')
                .html(compiledTemplate(this._content));
            return $('<div>').append($item).html();
        };

        return {
            ComboBoxItem: function (item) { return new ComboBoxItem(item); }
        };
    }());

    return ComboBoxItem.ComboBoxItem;
});