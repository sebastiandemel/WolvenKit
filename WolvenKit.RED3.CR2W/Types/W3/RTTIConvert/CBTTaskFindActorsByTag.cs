using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskFindActorsByTag : IBehTreeTask
	{
		[Ordinal(1)] [RED("tag")] 		public CName Tag { get; set;}

		[Ordinal(2)] [RED("actorsArray", 2,0)] 		public CArray<CHandle<CActor>> ActorsArray { get; set;}

		[Ordinal(3)] [RED("operator")] 		public CEnum<EOperator> Operator { get; set;}

		[Ordinal(4)] [RED("numberOfActors")] 		public CInt32 NumberOfActors { get; set;}

		[Ordinal(5)] [RED("range")] 		public CFloat Range { get; set;}

		[Ordinal(6)] [RED("oppNo")] 		public CInt32 OppNo { get; set;}

		[Ordinal(7)] [RED("onlyLiveActors")] 		public CBool OnlyLiveActors { get; set;}

		[Ordinal(8)] [RED("npc")] 		public CHandle<CNewNPC> Npc { get; set;}

		public CBTTaskFindActorsByTag(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}