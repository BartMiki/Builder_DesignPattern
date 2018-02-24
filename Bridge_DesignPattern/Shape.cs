namespace Bridge_DesignPattern
{
    public abstract class Shape
    {
        public string Name { get; set; }

        public IRenderer Renderer { get; }

        public Shape(IRenderer renderer)
        {
            Renderer = renderer;
        }

        public override string ToString() => Renderer.WhatToRenderAs.Replace("{Name}", Name);
    }
}