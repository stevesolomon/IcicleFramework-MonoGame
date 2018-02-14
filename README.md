# IcicleFramework-MonoGame
This represents an initial effort to port the IcicleFramework Game Framework from its original XNA implementation to MonoGame.

## Features Currently Cut
There were a few features that were necessary to cut at the start of this porting effort:

- Particles - Previously implemented using the Mercury Particle Engine, which is no longer supported. MonoGame.Extended.Particles is sufficiently different that the Particle System has been mostly disabled at this time. A fine opportunity to experiment with writing a fresh one :)
- Farseer Physics - Already deprecated in the original IcicleFramework, and nearly useless now as the MonoGame FarseerPhysics port has enough changes to render this feature useless. Work may be done to integrate a 2D physics engine such as Aether.
