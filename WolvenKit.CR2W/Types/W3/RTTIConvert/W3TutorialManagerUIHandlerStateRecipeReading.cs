using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3TutorialManagerUIHandlerStateRecipeReading : W3TutorialManagerUIHandlerStateTutHandlerBaseState
	{
		[RED("OPEN_INVENTORY")] 		public CName OPEN_INVENTORY { get; set;}

		[RED("SELECT_TAB")] 		public CName SELECT_TAB { get; set;}

		[RED("SELECT_BOOK")] 		public CName SELECT_BOOK { get; set;}

		[RED("USE")] 		public CName USE { get; set;}

		[RED("READ")] 		public CName READ { get; set;}

		[RED("isClosing")] 		public CBool IsClosing { get; set;}

		public W3TutorialManagerUIHandlerStateRecipeReading(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3TutorialManagerUIHandlerStateRecipeReading(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}