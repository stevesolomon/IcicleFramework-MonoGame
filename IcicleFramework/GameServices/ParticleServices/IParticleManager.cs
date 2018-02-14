using System.Collections.Generic;
using Microsoft.Xna.Framework;
using MonoGame.Extended.Particles;

namespace IcicleFramework.GameServices.ParticleServices
{
    public interface IParticleManager : IGameService
    {
        void EmitParticle(string particleName, Vector2 position);

        IEnumerable<ParticleEffect> GetAllActiveParticleEffects();
    }
}
