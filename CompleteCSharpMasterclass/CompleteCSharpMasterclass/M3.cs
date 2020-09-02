namespace CompleteCSharpMasterclass
{
    //a M3 is a BMW 
    public class M3 : Bmw
    {
        public M3 (int hp , string color ,string model) : base ( hp , color, model) 
        {
            this.Model = model;
        }

        //cannnot override base method Repair() - which is BMW Class's method, because that method is SEALED from being overridden by inherited classes.
        /*
        public override void Repair()
        {
            base.Repair();
        }
        */
    }
}