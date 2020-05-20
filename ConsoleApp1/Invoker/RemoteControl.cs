using CommandPattern.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Invoker
{
    public class RemoteControl
    {
        private const uint NumberOfSlots = 7;
        public ICommand[] OnCommands { get; private set; }
        public ICommand[] OffCommands { get; private set; }
        private Stack<ICommand> _commandStack;
        private static RemoteControl _remoteControll = new RemoteControl(); 

        /// <summary>
        /// Singleton Constructor
        /// </summary>
        private RemoteControl()
        {
            OnCommands = new ICommand[NumberOfSlots];
            OffCommands = new ICommand[NumberOfSlots];
            _commandStack = new Stack<ICommand>();
        }

        public static RemoteControl getInstance() => _remoteControll;

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            OnCommands[slot] = onCommand;
            OffCommands[slot] = offCommand;
        }
        public void OnButtonWasPushed(int slot)
        {
            OnCommands[slot].Execute();
            _commandStack.Push(OnCommands[slot]);
        }
        public void OffButtonWasPushed(int slot)
        {
            OffCommands[slot].Execute();
            _commandStack.Push(OffCommands[slot]);
        }

        public void UndoButtonWasPushed()
        {
            ICommand lastCommand = _commandStack.Count > 0 ? _commandStack.Pop() : null;
            lastCommand?.Undo();
        }
        public override String ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("\n------ Remote Control------ -\n");
            for (int i = 0; i < OnCommands.Length; i++)
                stringBuilder.Append($"[slot {i}]-[{OnCommands[i]?.GetType().Name},{OffCommands[i]?.GetType().Name}]\n");
            return stringBuilder.ToString();
        }
    }
}
