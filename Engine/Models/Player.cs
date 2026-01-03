using System.ComponentModel;

namespace Engine.Models
{
    public class Player : INotifyPropertyChanged
    {
        private string? _name;
        private string? _class;
        private int _hp;
        private int _exp;
        private int _level;
        private int _gold;

        public string? Name 
        { 
            get { return _name; }
            set
            {
                _name = value;
                OnPropChange("Name");
            }
        }
        public string? Class
        {
            get { return _class; }
            set
            {
                _class = value;
                OnPropChange("Class");
            }
        }
        public int HP
        {
            get { return _hp; }
            set
            {
                _hp = value;
                OnPropChange("HP");
            }
        }
        public int EXP
        { 
            get { return _exp; } 
            set 
            { 
                _exp = value;
                OnPropChange("EXP"); 
            }
        }
        public int Level
        {
            get { return _level; }
            set
            {
                _level = value;
                OnPropChange("Level");
            }
        }
        public int Gold
        {
            get { return _gold; }
            set
            {
                _gold = value;
                OnPropChange("Gold");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropChange(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}