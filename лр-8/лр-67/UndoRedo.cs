using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лр_67
{
    public class UndoRedo
    {
        private Stack<object> UndoStack;
        private Stack<object> RedoStack;
        public UndoRedo()
        {
            UndoStack = new Stack<object>();
            RedoStack = new Stack<object>();
        }

        public void Clear()
        {
            UndoStack.Clear();
            RedoStack.Clear();
        }

        public void AddItem(object item)
        {
            UndoStack.Push(item);
        }

        public object Undo()
        {
            object item = UndoStack.Pop();
            RedoStack.Push(item);
            return UndoStack.First();
        }

        public object Redo()
        {
            if (RedoStack.Count == 0)
                return UndoStack.First();
            object item = RedoStack.Pop();
            UndoStack.Push(item);
            return UndoStack.First();
        }

        public bool CanUndo()
        {
            return UndoStack.Count > 1;
        }

        public bool CanRedo()
        {
            return RedoStack.Count > 0;
        }

        public List<object> UndoItems()
        {
            return UndoStack.ToList();
        }

        public List<object> RedoItems()
        {
            return RedoStack.ToList();
        }
    }
}
