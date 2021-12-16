// See https://aka.ms/new-console-template for more information
using Exercism;
using Xunit;

var strings = new[] { "nail", "shoe" };
var expected = new[] { "For want of a nail the shoe was lost.", "And all for the want of a nail." };
var actual = Proverb.Recite(strings);

Assert.Equal(expected, Proverb.Recite(strings));