using System;

namespace _07_speed
{
    class TextBox : Actor
    {
        private InputService _input = new InputService();

        public TextBox()
        {
            _position = new Point(1,Constants.MAX_Y - 25);
            _width = 0;
            _height = 0;
            _text = "Buffer: ";
            
        }
        public void UpdateTextBox(string buffer)
        {
            _text = $"Buffer: {buffer}";
        }

    }
}