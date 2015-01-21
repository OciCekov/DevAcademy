define(['game/objects'], function (objects) {
    var Renderer;
    Renderer = (function () {
        var SNAKE_COLOR = 'gray',
            HEAD_COLOR = 'white',
            FOOD_COLOR = 'green';

        function Renderer() {
            var canvas = document.getElementsByTagName('canvas')[0];
            this._ctx = canvas.getContext('2d');
            this._width = canvas.width;
            this._height = canvas.height;
        }

        function DrawCircle(x, y, radius, fill) {
            this._ctx.fillStyle = fill;
            this._ctx.beginPath();
            this._ctx.arc(x, y, radius, 0, 2 * Math.PI);
            this._ctx.closePath();
            this._ctx.fill();
        }

        Renderer.prototype.render = function (gameObject) {
            var i;

            if (gameObject instanceof objects.Snake) {
                for (i = 1; i < gameObject.bodyLenght; i++) {
                    DrawCircle.call(this, gameObject._body[i].x + gameObject.bodySegment / 2, gameObject._body[i].y + gameObject.bodySegment / 2, gameObject.bodySegment / 2, SNAKE_COLOR);
                }
                this._ctx.clearRect(gameObject._forClear.x - 1, gameObject._forClear.y - 1, gameObject.bodySegment + 1, gameObject.bodySegment + 1);
                DrawCircle.call(this, gameObject._body[0].x + gameObject.bodySegment / 2, gameObject._body[0].y + gameObject.bodySegment / 2, gameObject.bodySegment / 2, HEAD_COLOR);
            } else {

                DrawCircle.call(this, gameObject._x + gameObject.bodySegment / 2, gameObject._y + gameObject.bodySegment / 2, gameObject.bodySegment / 2, FOOD_COLOR);
            }
        };

        return Renderer;
    }());

    return Renderer;
});