using P.Runtime;
using System.Collections.Generic;

namespace P.Program
{
    public class Application : StateImpl
    {
        public Application(): base ()
        {
        }

        public Application(bool initialize): base ()
        {
            CreateMainMachine();
        }

        public override StateImpl MakeSkeleton()
        {
            return new Application();
        }

        public static PrtEventValue halt = new PrtEventValue(new PrtEvent("halt", new PrtNullType(), 1, false));
        public static PrtEventValue @null = new PrtEventValue(new PrtEvent("null", new PrtNullType(), 1, false));
        public static PrtEventValue dummy = new PrtEventValue(new PrtEvent("dummy", new PrtNullType(), PrtEvent.DefaultMaxInstances, false));
        public PrtImplMachine CreateMainMachine()
        {
            var mainMachine = new Main(this, 10, false);
            AddImplMachineToStateImpl(mainMachine);
            return mainMachine;
        }

        public class Main : PrtImplMachine
        {
            public override PrtState StartState
            {
                get
                {
                    return Main_InitPingPong;
                }
            }

            public override PrtImplMachine MakeSkeleton()
            {
                return new Main();
            }

            public override int NextInstanceNumber(StateImpl app)
            {
                return app.NextMachineInstanceNumber(this.GetType());
            }

            public override string Name
            {
                get
                {
                    return "Main";
                }
            }

            public Main(): base ()
            {
            }

            public Main(StateImpl app, int maxB, bool assume): base (app, maxB, assume)
            {
            }

            public class AnonFun0_Class : PrtFun
            {
                public override bool IsAnonFun
                {
                    get
                    {
                        return true;
                    }
                }
                internal class AnonFun0_StackFrame : PrtFunStackFrame
                {
                    public AnonFun0_StackFrame(PrtFun fun, List<PrtValue> locs) : base(fun, locs)
                    {

                    }
                    public AnonFun0_StackFrame(PrtFun fun, List<PrtValue> locs, int retLocation)
                        : base(fun, locs, retLocation)
                    {

                    }
                    public override PrtFunStackFrame Clone()
                    {
                        return this.Clone();
                    }
                }
                public override void Execute(StateImpl application, PrtMachine parent)
                {
                    PrtFunStackFrame currFun = parent.PrtPopFunStackFrame();
                    if (currFun.returnToLocation == 0)
                        goto Loc_0;
                    else
                        goto Ret;
                    Loc_0:
                    Ret:
                        parent.PrtFunContReturn(null);
                }

                public override List<PrtValue> CreateLocals(params PrtValue[] args)
                {
                    var locals = new List<PrtValue>();
                    foreach (var item in args)
                    {
                        locals.Add(item.Clone());
                    }

                    //no local variables hence nothing to add
                    return locals;
                }
                public override PrtFunStackFrame CreateFunStackFrame(List<PrtValue> locals, int retLoc)
                {
                    //throw new NotImplementedException();
                    return new AnonFun0_StackFrame(this, locals, retLoc);
                }
            }

            public static AnonFun0_Class AnonFun0;
            public class AnonFun1_Class : PrtFun
            {
                public override bool IsAnonFun
                {
                    get
                    {
                        return true;
                    }
                }
                internal class AnonFun1_StackFrame : PrtFunStackFrame
                {
                    public AnonFun1_StackFrame(PrtFun fun, List<PrtValue> locs) : base(fun, locs)
                    {

                    }
                    public AnonFun1_StackFrame(PrtFun fun, List<PrtValue> locs, int retLocation)
                        : base(fun, locs, retLocation)
                    {

                    }
                    public override PrtFunStackFrame Clone()
                    {
                        return this.Clone();
                    }
                }
                public override void Execute(StateImpl application, PrtMachine parent)
                {
                    PrtFunStackFrame currFun = parent.PrtPopFunStackFrame();
                    if (currFun.returnToLocation == 0)
                        goto Loc_0;
                    else
                        goto Ret;
                    Loc_0:
                    Ret:
                        parent.PrtFunContReturn(null);
                }

                public override List<PrtValue> CreateLocals(params PrtValue[] args)
                {
                    var locals = new List<PrtValue>();
                    foreach (var item in args)
                    {
                        locals.Add(item.Clone());
                    }

                    //no local variables hence nothing to add
                    return locals;
                }
                public override PrtFunStackFrame CreateFunStackFrame(List<PrtValue> locals, int retLoc)
                {
                    //throw new NotImplementedException();
                    return new AnonFun1_StackFrame(this, locals, retLoc);
                }
            }

            public static AnonFun1_Class AnonFun1;
            public class AnonFun2_Class : PrtFun
            {
                public override bool IsAnonFun
                {
                    get
                    {
                        return true;
                    }
                }
                internal class AnonFun2_StackFrame : PrtFunStackFrame
                {
                    public AnonFun2_StackFrame(PrtFun fun, List<PrtValue> locs) : base(fun, locs)
                    {

                    }
                    public AnonFun2_StackFrame(PrtFun fun, List<PrtValue> locs, int retLocation)
                        : base(fun, locs, retLocation)
                    {

                    }
                    public override PrtFunStackFrame Clone()
                    {
                        return this.Clone();
                    }
                }
                public override void Execute(StateImpl application, PrtMachine parent)
                {
                    PrtFunStackFrame currFun = parent.PrtPopFunStackFrame();
                    if (currFun.returnToLocation == 0)
                        goto Loc_0;
                    else
                        goto Ret;
                    Loc_0:
                    Ret:
                        parent.PrtFunContReturn(null);
                }

                public override List<PrtValue> CreateLocals(params PrtValue[] args)
                {
                    var locals = new List<PrtValue>();
                    foreach (var item in args)
                    {
                        locals.Add(item.Clone());
                    }

                    //no local variables hence nothing to add
                    return locals;
                }
                public override PrtFunStackFrame CreateFunStackFrame(List<PrtValue> locals, int retLoc)
                {
                    //throw new NotImplementedException();
                    return new AnonFun2_StackFrame(this, locals, retLoc);
                }
            }

            public static AnonFun2_Class AnonFun2;
            public class foo_Class : PrtFun
            {
                public override bool IsAnonFun
                {
                    get
                    {
                        return false;
                    }
                }
                internal class foo_StackFrame : PrtFunStackFrame
                {
                    public foo_StackFrame(PrtFun fun, List<PrtValue> locs) : base(fun, locs)
                    {

                    }
                    public foo_StackFrame(PrtFun fun, List<PrtValue> locs, int retLocation)
                        : base(fun, locs, retLocation)
                    {

                    }
                    public override PrtFunStackFrame Clone()
                    {
                        return this.Clone();
                    }
                }
                public override void Execute(StateImpl application, PrtMachine parent)
                {
                    PrtFunStackFrame currFun = parent.PrtPopFunStackFrame();
                    if (currFun.returnToLocation == 0)
                        goto Loc_0;
                    else
                        goto Ret;
                    Loc_0:
                    Ret:
                        parent.PrtFunContReturn(null);
                }

                public override List<PrtValue> CreateLocals(params PrtValue[] args)
                {
                    var locals = new List<PrtValue>();
                    foreach (var item in args)
                    {
                        locals.Add(item.Clone());
                    }

                    //no local variables hence nothing to add
                    return locals;
                }
                public override PrtFunStackFrame CreateFunStackFrame(List<PrtValue> locals, int retLoc)
                {
                    //throw new NotImplementedException();
                    return new foo_StackFrame(this, locals, retLoc);
                }
            }

            public static foo_Class foo;
            public class bar_Class : PrtFun
            {
                public override bool IsAnonFun
                {
                    get
                    {
                        return false;
                    }
                }
                internal class bar_StackFrame : PrtFunStackFrame
                {
                    public bar_StackFrame(PrtFun fun, List<PrtValue> locs) : base(fun, locs)
                    {

                    }
                    public bar_StackFrame(PrtFun fun, List<PrtValue> locs, int retLocation)
                        : base(fun, locs, retLocation)
                    {

                    }
                    public override PrtFunStackFrame Clone()
                    {
                        return this.Clone();
                    }
                }
                public override void Execute(StateImpl application, PrtMachine parent)
                {
                    PrtFunStackFrame currFun = parent.PrtPopFunStackFrame();
                    if (currFun.returnToLocation == 0)
                        goto Loc_0;
                    else
                        goto Ret;
                    Loc_0:
                    Ret:
                        parent.PrtFunContReturn(null);
                }

                public override List<PrtValue> CreateLocals(params PrtValue[] args)
                {
                    var locals = new List<PrtValue>();
                    foreach (var item in args)
                    {
                        locals.Add(item.Clone());
                    }

                    //no local variables hence nothing to add
                    return locals;
                }
                public override PrtFunStackFrame CreateFunStackFrame(List<PrtValue> locals, int retLoc)
                {
                    //throw new NotImplementedException();
                    return new bar_StackFrame(this, locals, retLoc);
                }
            }

            public static bar_Class bar;
            public class AnonFun3_Class : PrtFun
            {
                public override bool IsAnonFun
                {
                    get
                    {
                        return true;
                    }
                }
                internal class AnonFun3_StackFrame : PrtFunStackFrame
                {
                    public AnonFun3_StackFrame(PrtFun fun, List<PrtValue> locs) : base(fun, locs)
                    {

                    }
                    public AnonFun3_StackFrame(PrtFun fun, List<PrtValue> locs, int retLocation)
                        : base(fun, locs, retLocation)
                    {

                    }
                    public override PrtFunStackFrame Clone()
                    {
                        return this.Clone();
                    }
                }
                public override void Execute(StateImpl application, PrtMachine parent)
                {
                    PrtFunStackFrame currFun = parent.PrtPopFunStackFrame();
                    if (currFun.returnToLocation == 0)
                        goto Loc_0;
                    else
                        goto Ret;
                    Loc_0:
                    Ret:
                        parent.PrtFunContReturn(null);
                }

                public override List<PrtValue> CreateLocals(params PrtValue[] args)
                {
                    var locals = new List<PrtValue>();
                    foreach (var item in args)
                    {
                        locals.Add(item.Clone());
                    }

                    //no local variables hence nothing to add
                    return locals;
                }
                public override PrtFunStackFrame CreateFunStackFrame(List<PrtValue> locals, int retLoc)
                {
                    //throw new NotImplementedException();
                    return new AnonFun3_StackFrame(this, locals, retLoc);
                }
            }

            public static AnonFun3_Class AnonFun3;
            public class AnonFun4_Class : PrtFun
            {
                public override bool IsAnonFun
                {
                    get
                    {
                        return true;
                    }
                }
                internal class AnonFun4_StackFrame : PrtFunStackFrame
                {
                    public AnonFun4_StackFrame(PrtFun fun, List<PrtValue> locs) : base(fun, locs)
                    {

                    }
                    public AnonFun4_StackFrame(PrtFun fun, List<PrtValue> locs, int retLocation)
                        : base(fun, locs, retLocation)
                    {

                    }
                    public override PrtFunStackFrame Clone()
                    {
                        return this.Clone();
                    }
                }
                public override void Execute(StateImpl application, PrtMachine parent)
                {
                    PrtFunStackFrame currFun = parent.PrtPopFunStackFrame();
                    if (currFun.returnToLocation == 0)
                        goto Loc_0;
                    else
                        goto Ret;
                    Loc_0:
                    Ret:
                        parent.PrtFunContReturn(null);
                }

                public override List<PrtValue> CreateLocals(params PrtValue[] args)
                {
                    var locals = new List<PrtValue>();
                    foreach (var item in args)
                    {
                        locals.Add(item.Clone());
                    }

                    //no local variables hence nothing to add
                    return locals;
                }
                public override PrtFunStackFrame CreateFunStackFrame(List<PrtValue> locals, int retLoc)
                {
                    //throw new NotImplementedException();
                    return new AnonFun4_StackFrame(this, locals, retLoc);
                }
            }

            public static AnonFun4_Class AnonFun4;
            public class Main_NewState_Class : PrtState
            {
                public Main_NewState_Class(string name, PrtFun entryFun, PrtFun exitFun, bool hasNullTransition, StateTemperature temperature): base (name, entryFun, exitFun, hasNullTransition, temperature)
                {
                }
            }

            public static Main_NewState_Class Main_NewState;
            public class Main_Success_Class : PrtState
            {
                public Main_Success_Class(string name, PrtFun entryFun, PrtFun exitFun, bool hasNullTransition, StateTemperature temperature): base (name, entryFun, exitFun, hasNullTransition, temperature)
                {
                }
            }

            public static Main_Success_Class Main_Success;
            public class Main_Fail_Class : PrtState
            {
                public Main_Fail_Class(string name, PrtFun entryFun, PrtFun exitFun, bool hasNullTransition, StateTemperature temperature): base (name, entryFun, exitFun, hasNullTransition, temperature)
                {
                }
            }

            public static Main_Fail_Class Main_Fail;
            public class Main_InitPingPong_Class : PrtState
            {
                public Main_InitPingPong_Class(string name, PrtFun entryFun, PrtFun exitFun, bool hasNullTransition, StateTemperature temperature): base (name, entryFun, exitFun, hasNullTransition, temperature)
                {
                }
            }

            public static Main_InitPingPong_Class Main_InitPingPong;
            static Main()
            {
                AnonFun0 = new AnonFun0_Class();
                AnonFun1 = new AnonFun1_Class();
                AnonFun2 = new AnonFun2_Class();
                foo = new foo_Class();
                bar = new bar_Class();
                AnonFun3 = new AnonFun3_Class();
                AnonFun4 = new AnonFun4_Class();
                Main_NewState = new Main_NewState_Class("Main_NewState", AnonFun0, AnonFun1, false, StateTemperature.Warm);
                Main_Success = new Main_Success_Class("Main_Success", AnonFun2, foo, false, StateTemperature.Warm);
                Main_Fail = new Main_Fail_Class("Main_Fail", foo, bar, false, StateTemperature.Warm);
                Main_InitPingPong = new Main_InitPingPong_Class("Main_InitPingPong", AnonFun3, AnonFun4, false, StateTemperature.Warm);
            }
        }
    }
}
