﻿namespace State
{
    public class ConcreteStateB : State
    {

        public override void Handle(Context context)
        {
            context.State = new ConcreteStateA();
        }
    }
}
