using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Roblox;

/// <summary>
/// See this wiki page for details on the bugs surround Neon orange and Deep orange (133, 1005, 1017)
/// https://confluence.roblox.com/display/PLATFORM/Avatar+Body+Colors
/// </summary>
[Serializable]
public class BrickColor
{
	public int ID;

	public string Name;

	public Color Color;

	/// <summary>
	/// The following Lua script generates this table:
	///
	/// function printBrick(i)
	///    local bc = BrickColor.new(i)
	///             local s = string.format([==[
	///    new BrickColor(%d, "%s", Color.FromArgb(%d, %d, %d)),
	///    ]==],
	///    bc.number, bc.name, 255 * bc.r, 255 * bc.g, 255 * bc.b)
	///    print(s)
	///             end
	///            printBrick(1);
	///            printBrick(208);
	///            printBrick(194);
	///            printBrick(199);
	///            printBrick(26);
	///            printBrick(21);
	///            printBrick(24);
	///            printBrick(226);
	///            printBrick(23);
	///            printBrick(107);
	///            printBrick(102);
	///            printBrick(11);
	///            printBrick(45);
	///            printBrick(135);
	///            printBrick(106);
	///            printBrick(105);
	///            printBrick(141);
	///            printBrick(28);
	///            printBrick(37);
	///            printBrick(119);
	///            printBrick(29);
	///            printBrick(151);
	///            printBrick(38);
	///            printBrick(192);
	///            printBrick(104);
	///            printBrick(9);
	///            printBrick(101);
	///            printBrick(5);
	///            printBrick(153);
	///            printBrick(217);
	///            printBrick(18);
	///            printBrick(125);
	///            printBrick(301);
	///            printBrick(303);
	///            printBrick(304);
	///            printBrick(302);
	///            printBrick(305);
	///            printBrick(306);
	///            printBrick(307);
	///            printBrick(308);
	///            printBrick(309);
	///            printBrick(310);
	///            printBrick(312);
	///            printBrick(313);
	///            printBrick(311);
	///            printBrick(315);
	///            printBrick(316);
	///            printBrick(317);
	///            printBrick(318);
	///            printBrick(319);
	///            printBrick(314);
	///            printBrick(321);
	///            printBrick(322);
	///            printBrick(323);
	///            printBrick(324);
	///            printBrick(325);
	///            printBrick(320);
	///            printBrick(327);
	///            printBrick(328);
	///            printBrick(329);
	///            printBrick(330);
	///            printBrick(331);
	///            printBrick(332);
	///            printBrick(333);
	///            printBrick(334);
	///            printBrick(335);
	///            printBrick(336);
	///            printBrick(342);
	///            printBrick(343);
	///            printBrick(338);
	///            printBrick(339);
	///            printBrick(133);
	///            printBrick(340);
	///            printBrick(341);
	///            printBrick(337);
	///            printBrick(344);
	///            printBrick(345);
	///            printBrick(346);
	///            printBrick(347);
	///            printBrick(348);
	///            printBrick(349);
	///            printBrick(350);
	///            printBrick(351);
	///            printBrick(352);
	///            printBrick(353);
	///            printBrick(354);
	///            printBrick(355);
	///            printBrick(356);
	///            printBrick(357);
	///            printBrick(358);
	///            printBrick(359);
	///            printBrick(360);
	///            printBrick(361);
	///            printBrick(362);
	///            printBrick(363);
	///            printBrick(364);
	///            printBrick(365);
	/// </summary>
	private static readonly BrickColor[] _Colors;

	private static readonly Dictionary<int, BrickColor> _LookupById;

	private static readonly BrickColor[] _AvatarPageAdvancedColorPalette;

	private static readonly BrickColor[] _AvatarPageBasicColorPalette;

	private static readonly BrickColor[] _AvatarValidColors;

	private static readonly BrickColor[] _HeadColors;

	private static readonly BrickColor[] _PrimaryColors;

	public static BrickColor DefaultBrickColor => Get(194);

	public BrickColor(int id, string name, Color color)
	{
		ID = id;
		Name = name;
		Color = color;
	}

	static BrickColor()
	{
		_Colors = new BrickColor[129]
		{
			new BrickColor(1, "White", Color.FromArgb(242, 243, 243)),
			new BrickColor(208, "Light stone grey", Color.FromArgb(229, 228, 223)),
			new BrickColor(194, "Medium stone grey", Color.FromArgb(163, 162, 165)),
			new BrickColor(199, "Dark stone grey", Color.FromArgb(99, 95, 98)),
			new BrickColor(26, "Black", Color.FromArgb(27, 42, 53)),
			new BrickColor(21, "Bright red", Color.FromArgb(196, 40, 28)),
			new BrickColor(24, "Bright yellow", Color.FromArgb(245, 205, 48)),
			new BrickColor(226, "Cool yellow", Color.FromArgb(253, 234, 141)),
			new BrickColor(23, "Bright blue", Color.FromArgb(13, 105, 172)),
			new BrickColor(107, "Bright bluish green", Color.FromArgb(0, 143, 156)),
			new BrickColor(102, "Medium blue", Color.FromArgb(110, 153, 202)),
			new BrickColor(11, "Pastel Blue", Color.FromArgb(128, 187, 220)),
			new BrickColor(45, "Light blue", Color.FromArgb(180, 210, 228)),
			new BrickColor(135, "Sand blue", Color.FromArgb(116, 134, 157)),
			new BrickColor(106, "Bright orange", Color.FromArgb(218, 133, 65)),
			new BrickColor(105, "Br. yellowish orange", Color.FromArgb(226, 155, 64)),
			new BrickColor(141, "Earth green", Color.FromArgb(39, 70, 45)),
			new BrickColor(28, "Dark green", Color.FromArgb(40, 127, 71)),
			new BrickColor(37, "Bright green", Color.FromArgb(75, 151, 75)),
			new BrickColor(119, "Br. yellowish green", Color.FromArgb(164, 189, 71)),
			new BrickColor(29, "Medium green", Color.FromArgb(161, 196, 140)),
			new BrickColor(151, "Sand green", Color.FromArgb(120, 144, 130)),
			new BrickColor(38, "Dark orange", Color.FromArgb(160, 95, 53)),
			new BrickColor(192, "Reddish brown", Color.FromArgb(105, 64, 40)),
			new BrickColor(104, "Bright violet", Color.FromArgb(107, 50, 124)),
			new BrickColor(9, "Light reddish violet", Color.FromArgb(232, 186, 200)),
			new BrickColor(101, "Medium red", Color.FromArgb(218, 134, 122)),
			new BrickColor(5, "Brick yellow", Color.FromArgb(215, 197, 154)),
			new BrickColor(153, "Sand red", Color.FromArgb(149, 121, 119)),
			new BrickColor(217, "Brown", Color.FromArgb(124, 92, 70)),
			new BrickColor(18, "Nougat", Color.FromArgb(204, 142, 105)),
			new BrickColor(125, "Light orange", Color.FromArgb(234, 184, 146)),
			new BrickColor(1001, "Institutional white", Color.FromArgb(248, 248, 248)),
			new BrickColor(1002, "Mid gray", Color.FromArgb(205, 205, 205)),
			new BrickColor(1003, "Really black", Color.FromArgb(17, 17, 17)),
			new BrickColor(1022, "Grime", Color.FromArgb(127, 142, 100)),
			new BrickColor(1023, "Lavender", Color.FromArgb(140, 91, 159)),
			new BrickColor(133, "Neon orange", Color.FromArgb(213, 115, 61)),
			new BrickColor(1018, "Teal", Color.FromArgb(18, 238, 212)),
			new BrickColor(1030, "Pastel brown", Color.FromArgb(255, 204, 153)),
			new BrickColor(1029, "Pastel yellow", Color.FromArgb(255, 255, 204)),
			new BrickColor(1025, "Pastel orange", Color.FromArgb(255, 201, 201)),
			new BrickColor(1016, "Pink", Color.FromArgb(255, 102, 204)),
			new BrickColor(1026, "Pastel violet", Color.FromArgb(177, 167, 255)),
			new BrickColor(1024, "Pastel light blue", Color.FromArgb(175, 221, 255)),
			new BrickColor(1027, "Pastel blue-green", Color.FromArgb(159, 243, 233)),
			new BrickColor(1028, "Pastel green", Color.FromArgb(204, 255, 204)),
			new BrickColor(1008, "Olive", Color.FromArgb(193, 190, 66)),
			new BrickColor(1009, "New Yeller", Color.FromArgb(255, 255, 0)),
			new BrickColor(1017, "Deep orange", Color.FromArgb(255, 175, 0)),
			new BrickColor(1005, "Deep orange", Color.FromArgb(255, 175, 0)),
			new BrickColor(1004, "Really red", Color.FromArgb(255, 0, 0)),
			new BrickColor(1032, "Hot pink", Color.FromArgb(255, 0, 191)),
			new BrickColor(1010, "Really blue", Color.FromArgb(0, 0, 255)),
			new BrickColor(1019, "Toothpaste", Color.FromArgb(0, 255, 255)),
			new BrickColor(1020, "Lime green", Color.FromArgb(0, 255, 0)),
			new BrickColor(1031, "Royal purple", Color.FromArgb(98, 37, 209)),
			new BrickColor(1006, "Alder", Color.FromArgb(180, 128, 255)),
			new BrickColor(1013, "Cyan", Color.FromArgb(4, 175, 236)),
			new BrickColor(1021, "Camo", Color.FromArgb(58, 125, 21)),
			new BrickColor(1014, "CGA brown", Color.FromArgb(170, 85, 0)),
			new BrickColor(1007, "Dusty Rose", Color.FromArgb(163, 75, 75)),
			new BrickColor(1015, "Magenta", Color.FromArgb(170, 0, 170)),
			new BrickColor(1012, "Deep blue", Color.FromArgb(33, 84, 185)),
			new BrickColor(1011, "Navy blue", Color.FromArgb(0, 32, 96)),
			new BrickColor(301, "Slime green", Color.FromArgb(80, 109, 84)),
			new BrickColor(303, "Dark blue", Color.FromArgb(0, 16, 176)),
			new BrickColor(304, "Parsley green", Color.FromArgb(44, 101, 29)),
			new BrickColor(302, "Smoky grey", Color.FromArgb(91, 93, 105)),
			new BrickColor(305, "Steel blue", Color.FromArgb(82, 124, 174)),
			new BrickColor(306, "Storm blue", Color.FromArgb(51, 88, 130)),
			new BrickColor(307, "Lapis", Color.FromArgb(16, 42, 220)),
			new BrickColor(308, "Dark indigo", Color.FromArgb(61, 21, 133)),
			new BrickColor(309, "Sea green", Color.FromArgb(52, 142, 64)),
			new BrickColor(310, "Shamrock", Color.FromArgb(91, 154, 76)),
			new BrickColor(312, "Mulberry", Color.FromArgb(89, 34, 89)),
			new BrickColor(313, "Forest green", Color.FromArgb(31, 128, 29)),
			new BrickColor(311, "Fossil", Color.FromArgb(159, 161, 172)),
			new BrickColor(315, "Electric blue", Color.FromArgb(9, 137, 207)),
			new BrickColor(316, "Eggplant", Color.FromArgb(123, 0, 123)),
			new BrickColor(317, "Moss", Color.FromArgb(124, 156, 107)),
			new BrickColor(318, "Artichoke", Color.FromArgb(138, 171, 133)),
			new BrickColor(319, "Sage green", Color.FromArgb(185, 196, 177)),
			new BrickColor(314, "Cadet blue", Color.FromArgb(159, 173, 192)),
			new BrickColor(321, "Lilac", Color.FromArgb(167, 94, 155)),
			new BrickColor(322, "Plum", Color.FromArgb(123, 47, 123)),
			new BrickColor(323, "Olivine", Color.FromArgb(148, 190, 129)),
			new BrickColor(324, "Laurel green", Color.FromArgb(168, 189, 153)),
			new BrickColor(325, "Quill grey", Color.FromArgb(223, 223, 222)),
			new BrickColor(320, "Ghost grey", Color.FromArgb(202, 203, 209)),
			new BrickColor(327, "Crimson", Color.FromArgb(151, 0, 0)),
			new BrickColor(328, "Mint", Color.FromArgb(177, 229, 166)),
			new BrickColor(329, "Baby blue", Color.FromArgb(152, 194, 219)),
			new BrickColor(330, "Carnation pink", Color.FromArgb(255, 152, 220)),
			new BrickColor(331, "Persimmon", Color.FromArgb(255, 89, 89)),
			new BrickColor(332, "Maroon", Color.FromArgb(117, 0, 0)),
			new BrickColor(333, "Gold", Color.FromArgb(239, 184, 56)),
			new BrickColor(334, "Daisy orange", Color.FromArgb(248, 217, 109)),
			new BrickColor(335, "Pearl", Color.FromArgb(231, 231, 236)),
			new BrickColor(336, "Fog", Color.FromArgb(199, 212, 228)),
			new BrickColor(342, "Mauve", Color.FromArgb(224, 178, 208)),
			new BrickColor(343, "Sunrise", Color.FromArgb(212, 144, 189)),
			new BrickColor(338, "Terra Cotta", Color.FromArgb(190, 104, 98)),
			new BrickColor(339, "Cocoa", Color.FromArgb(86, 36, 36)),
			new BrickColor(340, "Wheat", Color.FromArgb(241, 231, 199)),
			new BrickColor(341, "Buttermilk", Color.FromArgb(254, 243, 187)),
			new BrickColor(337, "Salmon", Color.FromArgb(255, 148, 148)),
			new BrickColor(344, "Tawny", Color.FromArgb(150, 85, 85)),
			new BrickColor(345, "Rust", Color.FromArgb(143, 76, 42)),
			new BrickColor(346, "Cashmere", Color.FromArgb(211, 190, 150)),
			new BrickColor(347, "Khaki", Color.FromArgb(226, 220, 188)),
			new BrickColor(348, "Lily white", Color.FromArgb(237, 234, 234)),
			new BrickColor(349, "Seashell", Color.FromArgb(233, 218, 218)),
			new BrickColor(350, "Burgundy", Color.FromArgb(136, 62, 62)),
			new BrickColor(351, "Cork", Color.FromArgb(188, 155, 93)),
			new BrickColor(352, "Burlap", Color.FromArgb(199, 172, 120)),
			new BrickColor(353, "Beige", Color.FromArgb(202, 191, 163)),
			new BrickColor(354, "Oyster", Color.FromArgb(187, 179, 178)),
			new BrickColor(355, "Pine Cone", Color.FromArgb(108, 88, 75)),
			new BrickColor(356, "Fawn brown", Color.FromArgb(160, 132, 79)),
			new BrickColor(357, "Hurricane grey", Color.FromArgb(149, 137, 136)),
			new BrickColor(358, "Cloudy grey", Color.FromArgb(171, 168, 158)),
			new BrickColor(359, "Linen", Color.FromArgb(175, 148, 131)),
			new BrickColor(360, "Copper", Color.FromArgb(150, 103, 102)),
			new BrickColor(361, "Dirt brown", Color.FromArgb(86, 66, 54)),
			new BrickColor(362, "Bronze", Color.FromArgb(126, 104, 63)),
			new BrickColor(363, "Flint", Color.FromArgb(105, 102, 92)),
			new BrickColor(364, "Dark taupe", Color.FromArgb(90, 76, 66)),
			new BrickColor(365, "Burnt Sienna", Color.FromArgb(106, 57, 9))
		};
		_LookupById = _Colors.ToDictionary((BrickColor c) => c.ID);
		_PrimaryColors = new BrickColor[12]
		{
			Get(1),
			Get(208),
			Get(194),
			Get(199),
			Get(26),
			Get(21),
			Get(24),
			Get(23),
			Get(102),
			Get(141),
			Get(37),
			Get(29)
		};
		_HeadColors = new BrickColor[4]
		{
			Get(1),
			Get(208),
			Get(194),
			Get(226)
		};
		_AvatarPageBasicColorPalette = new BrickColor[30]
		{
			Get(364),
			Get(217),
			Get(359),
			Get(18),
			Get(125),
			Get(361),
			Get(192),
			Get(351),
			Get(352),
			Get(5),
			Get(153),
			Get(1007),
			Get(101),
			Get(1025),
			Get(330),
			Get(135),
			Get(305),
			Get(11),
			Get(1026),
			Get(321),
			Get(107),
			Get(310),
			Get(317),
			Get(29),
			Get(105),
			Get(24),
			Get(334),
			Get(199),
			Get(1002),
			Get(1001)
		};
		_AvatarPageAdvancedColorPalette = new BrickColor[75]
		{
			Get(361),
			Get(192),
			Get(217),
			Get(153),
			Get(359),
			Get(352),
			Get(5),
			Get(101),
			Get(1007),
			Get(1014),
			Get(38),
			Get(18),
			Get(125),
			Get(1030),
			Get(133),
			Get(106),
			Get(105),
			Get(1017),
			Get(24),
			Get(334),
			Get(226),
			Get(141),
			Get(1021),
			Get(28),
			Get(37),
			Get(310),
			Get(317),
			Get(119),
			Get(1011),
			Get(1012),
			Get(1010),
			Get(23),
			Get(305),
			Get(102),
			Get(45),
			Get(107),
			Get(1018),
			Get(1027),
			Get(1019),
			Get(1013),
			Get(11),
			Get(1024),
			Get(104),
			Get(1023),
			Get(321),
			Get(1015),
			Get(1031),
			Get(1006),
			Get(1026),
			Get(21),
			Get(1004),
			Get(1032),
			Get(1016),
			Get(330),
			Get(9),
			Get(1025),
			Get(364),
			Get(351),
			Get(1008),
			Get(29),
			Get(1022),
			Get(151),
			Get(135),
			Get(1020),
			Get(1028),
			Get(1009),
			Get(1029),
			Get(1003),
			Get(26),
			Get(199),
			Get(194),
			Get(1002),
			Get(208),
			Get(1),
			Get(1001)
		};
		_AvatarValidColors = _AvatarPageAdvancedColorPalette.Concat(new BrickColor[1] { Get(1005) }).ToArray();
	}

	public static BrickColor[] Get()
	{
		return _Colors;
	}

	/// <summary>
	/// A subsets of the advanced color palette, only includes 30
	/// </summary>
	/// <returns></returns>
	public static BrickColor[] GetAvatarPageV2ColorPalette()
	{
		return _AvatarPageBasicColorPalette;
	}

	/// <summary>
	/// All valid brick Colors that can be used for body colors
	/// </summary>
	/// <returns></returns>
	public static BrickColor[] GetAllValidColors()
	{
		return _AvatarValidColors;
	}

	/// <summary>
	/// All BrickColors that are visible in the advanced color palette on the avatar page
	/// </summary>
	/// <returns></returns>
	public static BrickColor[] GetAdvancedColorPalette()
	{
		return _AvatarPageAdvancedColorPalette;
	}

	public static BrickColor Get(int id)
	{
		if (!_LookupById.TryGetValue(id, out var brickColor))
		{
			return null;
		}
		return brickColor;
	}

	public static BrickColor GetByRGB(byte r, byte g, byte b)
	{
		int givenColor = Color.FromArgb(r, g, b).ToArgb();
		return _Colors.FirstOrDefault((BrickColor color) => givenColor == color.Color.ToArgb());
	}

	public static BrickColor GetRandom()
	{
		int i = new Random().Next(_PrimaryColors.Length - 1);
		return _PrimaryColors[i];
	}

	public static BrickColor GetRandomHeadColor()
	{
		int i = new Random().Next(_HeadColors.Length - 1);
		return _HeadColors[i];
	}
}
