// <assemblyHash>d7920973</assemblyHash>
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.0.0
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//
//     This source code was auto-generated by Microsoft.QualityTools.Testing.Fakes, Version=15.0.0.0.
// </auto-generated>
#pragma warning disable 0067, 0108, 0618
#line hidden
extern alias anet;
extern alias mqttf;
extern alias sn;

[assembly: mqttf::Microsoft.QualityTools.Testing.Fakes.FakesAssembly("AlgoNET", false)]
[assembly: global::System.Reflection.AssemblyCompany("")]
[assembly: global::System.Reflection.AssemblyConfiguration("")]
[assembly: global::System.Reflection.AssemblyFileVersion("1.0.0.0")]
[assembly: global::System.Reflection.AssemblyProduct("AlgoNET")]
[assembly: global::System.Reflection.AssemblyVersion("1.0.0.0")]
namespace AlgoNET.Fakes
{
    /// <summary>Typ podkładki dla AlgoNET.FibModule</summary>
    [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimClass(typeof(anet::AlgoNET.FibModule))]
    [global::System.Diagnostics.DebuggerDisplay("Podk\u0142adka dla FibModule")]
    [global::System.Diagnostics.DebuggerNonUserCode]
    public partial class ShimFibModule
      : mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBase<anet::AlgoNET.FibModule>
    {
        /// <summary>Inicjuje nowe wystąpienie podkładki</summary>
        public ShimFibModule()
        : base()
        {
        }

        /// <summary>Inicjuje nową podkładkę dla danego wystąpienia</summary>
        public ShimFibModule(anet::AlgoNET.FibModule instance)
        : base(instance)
        {
        }

        /// <summary>Definiowanie podkładek dla wszystkich składowych wystąpień</summary>
        public static partial class AllInstances
        {
            /// <summary>Ustawia element podkładka dla: FibModule.fast_doubling(UInt64 n)</summary>
            public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<anet::AlgoNET.FibModule, ulong, sn::System.Numerics.BigInteger> fast_doublingUInt64
            {
                [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("fast_doubling", 20)]
                set
                {
                    mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                        ((global::System.Delegate)value, typeof(anet::AlgoNET.FibModule), (object)null, 
                         "fast_doubling", typeof(sn::System.Numerics.BigInteger), new global::System.Type[]{typeof(ulong)});
                }
            }

            /// <summary>Ustawia element podkładka dla: FibModule.get_values_from_range(UInt64 a, UInt64 b)</summary>
            public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<anet::AlgoNET.FibModule, ulong, ulong, global::System.Collections.Generic.List<string>> get_values_from_rangeUInt64UInt64
            {
                [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("get_values_from_range", 20)]
                set
                {
                    mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                        ((global::System.Delegate)value, typeof(anet::AlgoNET.FibModule), (object)null, "get_values_from_range", 
                                                                                                        typeof(global::System.Collections.Generic.List<string>), new global::System.Type[]{typeof(ulong), typeof(ulong)});
                }
            }

            /// <summary>Ustawia element podkładka dla: FibModule.textbook(UInt64 n)</summary>
            public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<anet::AlgoNET.FibModule, ulong, ulong> textbookUInt64
            {
                [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("textbook", 20)]
                set
                {
                    mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                        ((global::System.Delegate)value, typeof(anet::AlgoNET.FibModule), (object)null, 
                         "textbook", typeof(ulong), new global::System.Type[]{typeof(ulong)});
                }
            }
        }

        /// <summary>Przypisuje zachowanie „Current” dla wszystkich metod z typem zastąpionym podkładką</summary>
        public static void BehaveAsCurrent()
        {
            global::AlgoNET.Fakes.ShimFibModule.Behavior = mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.CurrentProxy;
        }

        /// <summary>Przypisuje zachowanie „NotImplemented” dla wszystkich metod z typem zastąpionym podkładką</summary>
        public static void BehaveAsNotImplemented()
        {
            global::AlgoNET.Fakes.ShimFibModule.Behavior = mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.NotImplemented;
        }

        /// <summary>Przypisuje zachowanie dla wszystkich metod z typem zastąpionym podkładką</summary>
        public static mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.IShimBehavior Behavior
        {
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimBehaviors.AttachToType(typeof(anet::AlgoNET.FibModule), value);
            }
        }

        /// <summary>Powiązuje składowe interfejsu z podkładką.</summary>
        public global::AlgoNET.Fakes.ShimFibModule Bind(anet::AlgoNET.IFibModule target)
        {
            if (target == (anet::AlgoNET.IFibModule)null)
              throw new global::System.ArgumentNullException("target");
            mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime
              .Bind<anet::AlgoNET.FibModule, global::AlgoNET.Fakes.ShimFibModule, anet::AlgoNET.IFibModule>(this, target);
            return this;
        }

        /// <summary>Ustawia element podkładka dla: FibModule.FibModule()</summary>
        public static mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Action<anet::AlgoNET.FibModule> Constructor
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod(".ctor", 20)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                    ((global::System.Delegate)value, typeof(anet::AlgoNET.FibModule), (object)null, ".ctor", typeof(void), new global::System.Type[]{});
            }
        }

        /// <summary>Ustawia element podkładka dla: FibModule.fast_doubling(UInt64 n)</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<ulong, sn::System.Numerics.BigInteger> fast_doublingUInt64
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("fast_doubling", 20)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance((global::System.Delegate)(
                                                                                                                             mqttf::Microsoft.QualityTools.Testing.Fakes.FakesExtensions.Uncurrify<anet::AlgoNET.FibModule, ulong, sn::System.Numerics.BigInteger>
                                                                                                                                 (value)), typeof(anet::AlgoNET.FibModule), base.Instance, 
                                                                                                    "fast_doubling", typeof(sn::System.Numerics.BigInteger), new global::System.Type[]{typeof(ulong)});
            }
        }

        /// <summary>Ustawia element podkładka dla: FibModule.get_values_from_range(UInt64 a, UInt64 b)</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<ulong, ulong, global::System.Collections.Generic.List<string>> get_values_from_rangeUInt64UInt64
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("get_values_from_range", 20)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance
                    ((global::System.Delegate)(mqttf::Microsoft.QualityTools.Testing.Fakes.FakesExtensions
                                                 .Uncurrify<anet::AlgoNET.FibModule, ulong, ulong, global::System.Collections.Generic.List<string>>(value)), 
                     typeof(anet::AlgoNET.FibModule), base.Instance, "get_values_from_range", 
                                                                                                                                                               typeof(global::System.Collections.Generic.List<string>), new global::System.Type[]{typeof(ulong), typeof(ulong)});
            }
        }

        /// <summary>Ustawia element podkładka dla: FibModule.textbook(UInt64 n)</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<ulong, ulong> textbookUInt64
        {
            [mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimMethod("textbook", 20)]
            set
            {
                mqttf::Microsoft.QualityTools.Testing.Fakes.Shims.ShimRuntime.SetShimPublicInstance((global::System.Delegate)
                                                                                                      (mqttf::Microsoft.QualityTools.Testing.Fakes.FakesExtensions.Uncurrify<anet::AlgoNET.FibModule, ulong, ulong>(value)), 
                                                                                                    typeof(anet::AlgoNET.FibModule), base.Instance, "textbook", typeof(ulong), new global::System.Type[]{typeof(ulong)});
            }
        }
    }
}
namespace AlgoNET.Fakes
{
    /// <summary>Typ klasy zastępczej dla AlgoNET.FibModule</summary>
    [mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubClass(typeof(anet::AlgoNET.FibModule))]
    [global::System.Diagnostics.DebuggerDisplay("Stub of FibModule")]
    [global::System.Diagnostics.DebuggerNonUserCode]
    public partial class StubFibModule
      : anet::AlgoNET.FibModule
      , mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStub<anet::AlgoNET.FibModule>
      , mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IPartialStub
    {
        /// <summary>Inicjuje nowe wystąpienie</summary>
        public StubFibModule()
        {
            this.InitializeStub();
        }

        /// <summary>Pobiera lub ustawia wartość określającą, czy zamiast zachowania alternatywnego należy wywołać metodę bazową</summary>
        public bool CallBase
        {
            get
            {
                return this.___callBase;
            }
            set
            {
                this.___callBase = value;
            }
        }

        /// <summary>Inicjuje nowe wystąpienie elementu type StubFibModule</summary>
        private void InitializeStub()
        {
        }

        /// <summary>Pobiera lub ustawia zachowanie wystąpienia.</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubBehavior InstanceBehavior
        {
            get
            {
                return mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubBehaviors.GetValueOrCurrent(this.___instanceBehavior);
            }
            set
            {
                this.___instanceBehavior = value;
            }
        }

        /// <summary>Pobiera lub ustawia obserwatora wystąpienia.</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubObserver InstanceObserver
        {
            get
            {
                return mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubObservers.GetValueOrCurrent(this.___instanceObserver);
            }
            set
            {
                this.___instanceObserver = value;
            }
        }

        private bool ___callBase;

        private mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubBehavior ___instanceBehavior;

        private mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubObserver ___instanceObserver;
    }
}
namespace AlgoNET.Fakes
{
    /// <summary>Typ klasy zastępczej dla AlgoNET.IFibModule</summary>
    [mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubClass(typeof(anet::AlgoNET.IFibModule))]
    [global::System.Diagnostics.DebuggerDisplay("Stub of IFibModule")]
    [global::System.Diagnostics.DebuggerNonUserCode]
    public partial class StubIFibModule
      : mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.StubBase<anet::AlgoNET.IFibModule>
      , anet::AlgoNET.IFibModule
    {
        /// <summary>Inicjuje nowe wystąpienie elementu type StubIFibModule</summary>
        public StubIFibModule()
        {
        }

        /// <summary>Ustawia element klasa zastępcza dla: IFibModule.fast_doubling(UInt64 n)</summary>
        sn::System.Numerics.BigInteger anet::AlgoNET.IFibModule.fast_doubling(ulong n)
        {
            mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubObserver ___observer
               = ((mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubObservable)this).InstanceObserver;
            if ((object)___observer != (object)null)
            {
              mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<ulong, sn::System.Numerics.BigInteger> ___currentMethod
                 = ((anet::AlgoNET.IFibModule)this).fast_doubling;
              ___observer.Enter(typeof(anet::AlgoNET.IFibModule), (global::System.Delegate)___currentMethod, (object)n);
            }
            mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<ulong, sn::System.Numerics.BigInteger> ___sh = this.Fast_doublingUInt64;
            if ((object)___sh != (object)null)
              return ___sh.Invoke(n);
            else 
            {
              mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubBehavior ___behavior
                 = ((mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStub)this).InstanceBehavior;
              return ___behavior.Result<global::AlgoNET.Fakes.StubIFibModule, sn::System.Numerics.BigInteger>(this, "AlgoNET.IFibModule.fast_doubling");
            }
        }

        /// <summary>Ustawia element klasa zastępcza dla: IFibModule.get_values_from_range(UInt64 a, UInt64 b)</summary>
        global::System.Collections.Generic.List<string> anet::AlgoNET.IFibModule.get_values_from_range(ulong a, ulong b)
        {
            mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubObserver ___observer
               = ((mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubObservable)this).InstanceObserver;
            if ((object)___observer != (object)null)
            {
              mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<ulong, ulong, global::System.Collections.Generic.List<string>> 
                ___currentMethod = ((anet::AlgoNET.IFibModule)this).get_values_from_range;
              ___observer.Enter(typeof(anet::AlgoNET.IFibModule), (global::System.Delegate)___currentMethod, (object)a, (object)b);
            }
            mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<ulong, ulong, global::System.Collections.Generic.List<string>> ___sh
               = this.Values_from_rangeGetUInt64UInt64;
            if ((object)___sh != (object)null)
              return ___sh.Invoke(a, b);
            else 
            {
              mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubBehavior ___behavior
                 = ((mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStub)this).InstanceBehavior;
              return ___behavior.Result<global::AlgoNET.Fakes.StubIFibModule, global::System.Collections.Generic.List<string>>
                         (this, "AlgoNET.IFibModule.get_values_from_range");
            }
        }

        /// <summary>Ustawia element klasa zastępcza dla: IFibModule.textbook(UInt64 n)</summary>
        ulong anet::AlgoNET.IFibModule.textbook(ulong n)
        {
            mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubObserver ___observer
               = ((mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubObservable)this).InstanceObserver;
            if ((object)___observer != (object)null)
            {
              mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<ulong, ulong> ___currentMethod = ((anet::AlgoNET.IFibModule)this).textbook
                ;
              ___observer.Enter(typeof(anet::AlgoNET.IFibModule), (global::System.Delegate)___currentMethod, (object)n);
            }
            mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<ulong, ulong> ___sh = this.TextbookUInt64;
            if ((object)___sh != (object)null)
              return ___sh.Invoke(n);
            else 
            {
              mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStubBehavior ___behavior
                 = ((mqttf::Microsoft.QualityTools.Testing.Fakes.Stubs.IStub)this).InstanceBehavior;
              return ___behavior.Result<global::AlgoNET.Fakes.StubIFibModule, ulong>(this, "AlgoNET.IFibModule.textbook");
            }
        }

        /// <summary>Ustawia element stub dla: IFibModule.fast_doubling(UInt64 n)</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<ulong, sn::System.Numerics.BigInteger> Fast_doublingUInt64;

        /// <summary>Ustawia element stub dla: IFibModule.textbook(UInt64 n)</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<ulong, ulong> TextbookUInt64;

        /// <summary>Ustawia element stub dla: IFibModule.get_values_from_range(UInt64 a, UInt64 b)</summary>
        public mqttf::Microsoft.QualityTools.Testing.Fakes.FakesDelegates.Func<ulong, ulong, global::System.Collections.Generic.List<string>> Values_from_rangeGetUInt64UInt64;
    }
}
