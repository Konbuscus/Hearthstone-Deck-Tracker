using HearthDb.Enums;

namespace Hearthstone_Deck_Tracker.Enums
{
	public enum ArenaRewardPacks
	{
		[LocDescription("Enum_ArenaRewardPacks_None")]
		None = CardSet.INVALID,

		[LocDescription("Enum_ArenaRewardPacks_Classic")]
		Classic = CardSet.CORE,

		[LocDescription("Enum_ArenaRewardPacks_GoblinsVsGnomes")]
		GoblinsVsGnomes = CardSet.GVG,

		[LocDescription("Enum_ArenaRewardPacks_TheGrandTournament")]
		TheGrandTournament = CardSet.TGT,

		[LocDescription("Enum_ArenaRewardPacks_WhispersOfTheOldGods")]
		WhispersOfTheOldGods = CardSet.OG,

		[LocDescription("Enum_ArenaRewardPacks_MeanStreetsOfGadgetzan")]
		MeanStreetsOfGadgetzan = CardSet.GANGS,

		[LocDescription("Enum_ArenaRewardPacks_JourneyToUngoro")]
		JourneyToUngoro = CardSet.UNGORO,

		[LocDescription("Enum_ArenaRewardPacks_KnightsOfTheFrozenThrone")]
		KnightsOfTheFrozenThrone = CardSet.ICECROWN
	}
}
