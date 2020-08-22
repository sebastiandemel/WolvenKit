using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphNode : CGraphBlock
	{
		[RED("name")] 		public CString Name { get; set;}

		[RED("color")] 		public CColor Color { get; set;}

		[RED("activateNotification")] 		public CName ActivateNotification { get; set;}

		[RED("deactivateNotification")] 		public CName DeactivateNotification { get; set;}

		[RED("generateEditorFragments")] 		public CBool GenerateEditorFragments { get; set;}

		[RED("id")] 		public CUInt32 Id { get; set;}

		[RED("logOnActivation")] 		public CString LogOnActivation { get; set;}

		[RED("debugCodeId")] 		public CInt32 DebugCodeId { get; set;}

		[RED("debugCodeBreak_Act")] 		public CBool DebugCodeBreak_Act { get; set;}

		[RED("debugCodeBreak_Deact")] 		public CBool DebugCodeBreak_Deact { get; set;}

		public CBehaviorGraphNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}