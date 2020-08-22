using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Effect_Drowning : W3DamageOverTimeEffect
	{
		[RED("m_NoSaveLockInt")] 		public CInt32 M_NoSaveLockInt { get; set;}

		[RED("isEffectOn")] 		public CBool IsEffectOn { get; set;}

		[RED("mac")] 		public CHandle<CMovingPhysicalAgentComponent> Mac { get; set;}

		[RED("submergeDepth")] 		public CFloat SubmergeDepth { get; set;}

		public W3Effect_Drowning(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3Effect_Drowning(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}