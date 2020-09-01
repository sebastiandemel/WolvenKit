using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMaterialBlockSamplerNormalArray : CMaterialBlock
	{
		[Ordinal(1)] [RED("subUVWidth")] 		public CUInt32 SubUVWidth { get; set;}

		[Ordinal(2)] [RED("subUVHeight")] 		public CUInt32 SubUVHeight { get; set;}

		[Ordinal(3)] [RED("subUVInterpolate")] 		public CBool SubUVInterpolate { get; set;}

		public CMaterialBlockSamplerNormalArray(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMaterialBlockSamplerNormalArray(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}