namespace RPSGameTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestRoundWinner()
        {
            // Arrange
            var game = new RPSGame.RPSGame("Player");

            // Test 1: Player wins
            string playerMove1 = "Rock";
            string aiMove1 = "Scissors";
            int expectedWinner1 = 1; // Player should win

            // Act
            int actualWinner1 = game.CompareMoves(playerMove1, aiMove1);

            // Assert
            Assert.Equal(expectedWinner1, actualWinner1);

            // Test 2: AI wins
            string playerMove2 = "Paper";
            string aiMove2 = "Scissors";
            int expectedWinner2 = -1; // AI should win

            // Act
            int actualWinner2 = game.CompareMoves(playerMove2, aiMove2);

            // Assert
            Assert.Equal(expectedWinner2, actualWinner2);

            // Test 3: Draw
            string playerMove3 = "Rock";
            string aiMove3 = "Rock";
            int expectedWinner3 = 0; // Draw

            // Act
            int actualWinner3 = game.CompareMoves(playerMove3, aiMove3);

            // Assert
            Assert.Equal(expectedWinner3, actualWinner3);
        }

        [Fact]
        public void TestScoreUpdate()
        {
            // Arrange
            var game = new RPSGame.RPSGame("Player");
            game.Computer.Score = 1; // Simulate AI having won a round

            // Act
            game.HumanPlayer.Score++; // Simulate Player winning a round

            // Assert
            Assert.Equal(1, game.HumanPlayer.Score); // Player score should be updated to 1
            Assert.Equal(1, game.Computer.Score); // AI score should remain 1 (not updated)
        }
    }
}
