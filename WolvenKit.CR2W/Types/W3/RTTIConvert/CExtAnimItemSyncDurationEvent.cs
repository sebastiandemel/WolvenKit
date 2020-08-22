using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExtAnimItemSyncDurationEvent : CExtAnimDurationEvent
	{
		[RED("equipSlot")] 		public CName EquipSlot { get; set;}

		[RED("holdSlot")] 		public CName HoldSlot { get; set;}

		[RED("action")] 		public CEnum<EItemLatentAction> Action { get; set;}

		public CExtAnimItemSyncDurationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExtAnimItemSyncDurationEvent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}