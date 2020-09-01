using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeScriptTerminalDefinition : IBehTreeNodeDefinition
	{
		[Ordinal(1)] [RED("taskOrigin")] 		public CHandle<IBehTreeTaskDefinition> TaskOrigin { get; set;}

		[Ordinal(2)] [RED("skipIfActive")] 		public CBool SkipIfActive { get; set;}

		[Ordinal(3)] [RED("runMainOnActivation")] 		public CBool RunMainOnActivation { get; set;}

		public CBehTreeNodeScriptTerminalDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeNodeScriptTerminalDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}