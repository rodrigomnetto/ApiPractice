using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiPractice.Migrations
{
    public partial class CharacterSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(table: "characters"
                                    , columns: new[] { "name", "description" }
                                     , values: new object[] { "Iron Man", "Wounded, captured and forced to build a weapon by his enemies, billionaire industrialist Tony Stark instead created an advanced suit of armor to save his life and escape captivity. Now with a new outlook on life, Tony uses his money and intelligence to make the world a safer, better place as Iron Man." });

            migrationBuilder.InsertData(table: "characters"
                                    , columns: new[] { "name", "description" }
                                     , values: new object[] { "Spider-Man", "Bitten by a radioactive spider, high school student Peter Parker gained the speed, strength and powers of a spider. Adopting the name Spider-Man, Peter hoped to start a career using his new abilities. Taught that with great power comes great responsibility, Spidey has vowed to use his powers to help people." });

            migrationBuilder.InsertData(table: "characters"
                                    , columns: new[] { "name", "description" }
                                     , values: new object[] { "Hulk", "Caught in a gamma bomb explosion while trying to save the life of a teenager, Dr. Bruce Banner was transformed into the incredibly powerful creature called the Hulk. An all too often misunderstood hero, the angrier the Hulk gets, the stronger the Hulk gets." });

            migrationBuilder.InsertData(table: "characters"
                                    , columns: new[] { "name", "description" }
                                     , values: new object[] { "Thor", "As the Norse God of thunder and lightning, Thor wields one of the greatest weapons ever made, the enchanted hammer Mjolnir. While others have described Thor as an over-muscled, oafish imbecile, he's quite smart and compassionate.  He's self-assured, and he would never, ever stop fighting for a worthwhile cause." });

            migrationBuilder.InsertData(table: "characters"
                                    , columns: new[] { "name", "description" }
                                     , values: new object[] { "Black Widow", "Trusted by some and feared by most, the Black Widow strives to make up for the bad she had done in the past by helping the world, even if that means getting her hands dirty in the process." });

            migrationBuilder.InsertData(table: "characters"
                                    , columns: new[] { "name", "description" }
                                     , values: new object[] { "Doctor Strange", "Once a highly successful, yet notably egotistical, surgeon, Doctor Stephen Strange endured a terrible accident that led him to evolve in ways he could have never foreseen." });

            migrationBuilder.InsertData(table: "characters"
                                    , columns: new[] { "name", "description" }
                                     , values: new object[] { "Captain America", "Vowing to serve his country any way he could, young Steve Rogers took the super soldier serum to become America's one-man army. Fighting for the red, white and blue for over 60 years, Captain America is the living, breathing symbol of freedom and liberty." });

            migrationBuilder.InsertData(table: "characters"
                                    , columns: new[] { "name", "description" }
                                     , values: new object[] { "Ms. Marvel (Kamala Khan)", "A Muslim-American teenager growing up in Jersey City, Kamala Khan gained shape-shifting powers when Inhumanity spread over the Earth. A fan of super heroes, in particular Carol Danvers, Kamala took up Captain Marvel's former identity, becoming the new Ms. Marvel. This up and coming hero works to protect her community and understand her place in the world." });

            migrationBuilder.InsertData(table: "characters"
                                    , columns: new[] { "name", "description" }
                                     , values: new object[] { "Ant-Man", "Ex-con Scott Lang uses high-tech equipment to shrink down to insect-size and fight injustice as Ant-Man." });

            migrationBuilder.InsertData(table: "characters"
                                    , columns: new[] { "name", "description" }
                                     , values: new object[] { "Vision", "The metal monstrosity called Ultron created the synthetic humanoid known as the Vision from the remains of the original android Human Torch of the 1940s to serve as a vehicle of vengeance against the Avengers." });

            migrationBuilder.InsertData(table: "characters"
                                    , columns: new[] { "name", "description" }
                                     , values: new object[] { "Black Panther", "T’Challa is the king of the secretive and highly advanced African nation of Wakanda - as well as the powerful warrior known as the Black Panther." });

            migrationBuilder.InsertData(table: "characters"
                                    , columns: new[] { "name", "description" }
                                     , values: new object[] { "Loki", "God of Mischief and brother to Thor, Loki’s tricks and schemes wreak havoc across the realms." });

            migrationBuilder.InsertData(table: "characters"
                                    , columns: new[] { "name", "description" }
                                     , values: new object[] { "Captain Marvel (Carol Danvers)", "Carol Danvers becomes one of the universe's most powerful heroes when Earth is caught in the middle of a galactic war between two alien races." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(table: "characters"
                                 , keyColumns: new[] { "name", "description" }
                                  , keyValues: new object[] { "Iron Man", "Wounded, captured and forced to build a weapon by his enemies, billionaire industrialist Tony Stark instead created an advanced suit of armor to save his life and escape captivity. Now with a new outlook on life, Tony uses his money and intelligence to make the world a safer, better place as Iron Man." });

            migrationBuilder.DeleteData(table: "characters"
                                 , keyColumns: new[] { "name", "description" }
                                  , keyValues: new object[] { "Spider-Man", "Bitten by a radioactive spider, high school student Peter Parker gained the speed, strength and powers of a spider. Adopting the name Spider-Man, Peter hoped to start a career using his new abilities. Taught that with great power comes great responsibility, Spidey has vowed to use his powers to help people." });

            migrationBuilder.DeleteData(table: "characters"
                                 , keyColumns: new[] { "name", "description" }
                                  , keyValues: new object[] { "Hulk", "Caught in a gamma bomb explosion while trying to save the life of a teenager, Dr. Bruce Banner was transformed into the incredibly powerful creature called the Hulk. An all too often misunderstood hero, the angrier the Hulk gets, the stronger the Hulk gets." });

            migrationBuilder.DeleteData(table: "characters"
                                 , keyColumns: new[] { "name", "description" }
                                  , keyValues: new object[] { "Thor", "As the Norse God of thunder and lightning, Thor wields one of the greatest weapons ever made, the enchanted hammer Mjolnir. While others have described Thor as an over-muscled, oafish imbecile, he's quite smart and compassionate.  He's self-assured, and he would never, ever stop fighting for a worthwhile cause." });

            migrationBuilder.DeleteData(table: "characters"
                                 , keyColumns: new[] { "name", "description" }
                                  , keyValues: new object[] { "Black Widow", "Trusted by some and feared by most, the Black Widow strives to make up for the bad she had done in the past by helping the world, even if that means getting her hands dirty in the process." });

            migrationBuilder.DeleteData(table: "characters"
                                 , keyColumns: new[] { "name", "description" }
                                  , keyValues: new object[] { "Doctor Strange", "Once a highly successful, yet notably egotistical, surgeon, Doctor Stephen Strange endured a terrible accident that led him to evolve in ways he could have never foreseen." });

            migrationBuilder.DeleteData(table: "characters"
                                 , keyColumns: new[] { "name", "description" }
                                  , keyValues: new object[] { "Captain America", "Vowing to serve his country any way he could, young Steve Rogers took the super soldier serum to become America's one-man army. Fighting for the red, white and blue for over 60 years, Captain America is the living, breathing symbol of freedom and liberty." });

            migrationBuilder.DeleteData(table: "characters"
                                 , keyColumns: new[] { "name", "description" }
                                  , keyValues: new object[] { "Ms. Marvel (Kamala Khan)", "A Muslim-American teenager growing up in Jersey City, Kamala Khan gained shape-shifting powers when Inhumanity spread over the Earth. A fan of super heroes, in particular Carol Danvers, Kamala took up Captain Marvel's former identity, becoming the new Ms. Marvel. This up and coming hero works to protect her community and understand her place in the world." });

            migrationBuilder.DeleteData(table: "characters"
                                 , keyColumns: new[] { "name", "description" }
                                  , keyValues: new object[] { "Ant-Man", "Ex-con Scott Lang uses high-tech equipment to shrink down to insect-size and fight injustice as Ant-Man." });

            migrationBuilder.DeleteData(table: "characters"
                                 , keyColumns: new[] { "name", "description" }
                                  , keyValues: new object[] { "Vision", "The metal monstrosity called Ultron created the synthetic humanoid known as the Vision from the remains of the original android Human Torch of the 1940s to serve as a vehicle of vengeance against the Avengers." });

            migrationBuilder.DeleteData(table: "characters"
                                 , keyColumns: new[] { "name", "description" }
                                  , keyValues: new object[] { "Black Panther", "T’Challa is the king of the secretive and highly advanced African nation of Wakanda - as well as the powerful warrior known as the Black Panther." });

            migrationBuilder.DeleteData(table: "characters"
                                 , keyColumns: new[] { "name", "description" }
                                  , keyValues: new object[] { "Loki", "God of Mischief and brother to Thor, Loki’s tricks and schemes wreak havoc across the realms." });

            migrationBuilder.DeleteData(table: "characters"
                                 , keyColumns: new[] { "name", "description" }
                                  , keyValues: new object[] { "Captain Marvel (Carol Danvers)", "Carol Danvers becomes one of the universe's most powerful heroes when Earth is caught in the middle of a galactic war between two alien races." });
        }
    }
}
