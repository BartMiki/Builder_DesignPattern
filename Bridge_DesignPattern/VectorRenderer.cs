namespace Bridge_DesignPattern
{
    public class VectorRenderer : IRenderer
    {
        public VectorRenderer()
        {
            WhatToRenderAs = "Drawing {Name} as lines";
        }
        public string WhatToRenderAs { get; }
    }
}