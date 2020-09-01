using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SStoryBoardPlacementSettings : CVariable
	{
		[Ordinal(1)] [RED("pos")] 		public Vector Pos { get; set;}

		[Ordinal(2)] [RED("rot")] 		public EulerAngles Rot { get; set;}

		[Ordinal(3)] [RED("isHidden")] 		public CBool IsHidden { get; set;}

		public SStoryBoardPlacementSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SStoryBoardPlacementSettings(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}