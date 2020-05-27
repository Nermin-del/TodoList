using System;
using System.Collections.Generic;
using System.Text;

namespace TodoList
{
    class SelectAtTodo
    {
        private string _whatToDo;
        public SelectAtTodo(string whatToDo)
        {
            _whatToDo = whatToDo;
        }


        public void toString()
        {
            Console.WriteLine(_whatToDo);
        }
    }
}
