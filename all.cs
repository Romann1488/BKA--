using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;
using TMPro;
using UnityEngine.UI;

namespace Armor
{
    public class Mod
    {
        public static void Main()
        {
CategoryBuilder.Create("BKA", "", ModAPI.LoadSprite("category icon.png"));    


ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Air defense assistant UBY",
                    NameToOrderByOverride = "a",
                    DescriptionOverride = "Air defense assistant UBY",
                    CategoryOverride = ModAPI.FindCategory("BKA"),
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none.png"),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Outfit/Air defense assistant UBY.png");
						var flesh = ModAPI.LoadTexture("flesh.png");
						var bone = ModAPI.LoadTexture("bone.png");
                        Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, flesh, bone);

                        //get person
                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin, flesh, bone, 12);
                    }
                }
            );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Air defense assistant-SS trainee UBY",
                    NameToOrderByOverride = "a",
                    DescriptionOverride = "Air defense assistant-SS trainee UBY",
                    CategoryOverride = ModAPI.FindCategory("BKA"),
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none.png"),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Outfit/Air defense assistant-SS trainee UBY.png");
						var flesh = ModAPI.LoadTexture("flesh.png");
						var bone = ModAPI.LoadTexture("bone.png");
                        Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, flesh, bone);

                        //get person
                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin, flesh, bone, 12);
                    }
                }
            );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Battalion Instructor Dalwitz",
                    NameToOrderByOverride = "a",
                    DescriptionOverride = "Battalion Instructor Dalwitz",
                    CategoryOverride = ModAPI.FindCategory("BKA"),
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none.png"),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Outfit/Battalion Instructor Dalwitz.png");
						var flesh = ModAPI.LoadTexture("flesh.png");
						var bone = ModAPI.LoadTexture("bone.png");
                        Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, flesh, bone);

                        //get person
                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin, flesh, bone, 12);
                    }
                }
            );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Belarussian Collaborator",
                    NameToOrderByOverride = "a",
                    DescriptionOverride = "Belarussian Collaborator",
                    CategoryOverride = ModAPI.FindCategory("BKA"),
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none.png"),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Outfit/Belarussian Collaborator.png");
						var flesh = ModAPI.LoadTexture("flesh.png");
						var bone = ModAPI.LoadTexture("bone.png");
                        Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, flesh, bone);

                        //get person
                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin, flesh, bone, 12);
                    }
                }
            );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Belarussian Collaborator 2",
                    NameToOrderByOverride = "a",
                    DescriptionOverride = "Belarussian Collaborator 2",
                    CategoryOverride = ModAPI.FindCategory("BKA"),
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none.png"),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Outfit/Belarussian Collaborator 2.png");
						var flesh = ModAPI.LoadTexture("flesh.png");
						var bone = ModAPI.LoadTexture("bone.png");
                        Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, flesh, bone);

                        //get person
                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin, flesh, bone, 12);
                    }
                }
            );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Belarussian Collaborator 3",
                    NameToOrderByOverride = "a",
                    DescriptionOverride = "Belarussian Collaborator 3",
                    CategoryOverride = ModAPI.FindCategory("BKA"),
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none.png"),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Outfit/Belarussian Collaborator 3.png");
						var flesh = ModAPI.LoadTexture("flesh.png");
						var bone = ModAPI.LoadTexture("bone.png");
                        Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, flesh, bone);

                        //get person
                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin, flesh, bone, 12);
                    }
                }
            );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Belarussian Collaborator 4",
                    NameToOrderByOverride = "a",
                    DescriptionOverride = "Belarussian Collaborator 4",
                    CategoryOverride = ModAPI.FindCategory("BKA"),
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none.png"),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Outfit/Belarussian Collaborator 4.png");
						var flesh = ModAPI.LoadTexture("flesh.png");
						var bone = ModAPI.LoadTexture("bone.png");
                        Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, flesh, bone);

                        //get person
                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin, flesh, bone, 12);
                    }
                }
            );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Belarussian Collaborator 5",
                    NameToOrderByOverride = "a",
                    DescriptionOverride = "Belarussian Collaborator 5",
                    CategoryOverride = ModAPI.FindCategory("BKA"),
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none.png"),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Outfit/Belarussian Collaborator 5.png");
						var flesh = ModAPI.LoadTexture("flesh.png");
						var bone = ModAPI.LoadTexture("bone.png");
                        Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, flesh, bone);

                        //get person
                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin, flesh, bone, 12);
                    }
                }
            );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Belarussian Collaborator 6",
                    NameToOrderByOverride = "a",
                    DescriptionOverride = "Belarussian Collaborator 6",
                    CategoryOverride = ModAPI.FindCategory("BKA"),
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none.png"),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Outfit/Belarussian Collaborator 6.png");
						var flesh = ModAPI.LoadTexture("flesh.png");
						var bone = ModAPI.LoadTexture("bone.png");
                        Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, flesh, bone);

                        //get person
                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin, flesh, bone, 12);
                    }
                }
            );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Belarussian Collaborator 7",
                    NameToOrderByOverride = "a",
                    DescriptionOverride = "Belarussian Collaborator 7",
                    CategoryOverride = ModAPI.FindCategory("BKA"),
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none.png"),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Outfit/Belarussian Collaborator 7.png");
						var flesh = ModAPI.LoadTexture("flesh.png");
						var bone = ModAPI.LoadTexture("bone.png");
                        Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, flesh, bone);

                        //get person
                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin, flesh, bone, 12);
                    }
                }
            );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Belarussian Collaborator 8",
                    NameToOrderByOverride = "a",
                    DescriptionOverride = "Belarussian Collaborator 8",
                    CategoryOverride = ModAPI.FindCategory("BKA"),
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none.png"),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Outfit/Belarussian Collaborator 8.png");
						var flesh = ModAPI.LoadTexture("flesh.png");
						var bone = ModAPI.LoadTexture("bone.png");
                        Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, flesh, bone);

                        //get person
                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin, flesh, bone, 12);
                    }
                }
            );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Belarussian Collaborator 9",
                    NameToOrderByOverride = "a",
                    DescriptionOverride = "Belarussian Collaborator 9",
                    CategoryOverride = ModAPI.FindCategory("BKA"),
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none.png"),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Outfit/Belarussian Collaborator 9.png");
						var flesh = ModAPI.LoadTexture("flesh.png");
						var bone = ModAPI.LoadTexture("bone.png");
                        Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, flesh, bone);

                        //get person
                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin, flesh, bone, 12);
                    }
                }
            );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Belarussian Collaborator 10",
                    NameToOrderByOverride = "a",
                    DescriptionOverride = "Belarussian Collaborator 10",
                    CategoryOverride = ModAPI.FindCategory("BKA"),
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none.png"),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Outfit/Belarussian Collaborator 10.png");
						var flesh = ModAPI.LoadTexture("flesh.png");
						var bone = ModAPI.LoadTexture("bone.png");
                        Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, flesh, bone);

                        //get person
                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin, flesh, bone, 12);
                    }
                }
            );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Belarussian Collaborator 11",
                    NameToOrderByOverride = "a",
                    DescriptionOverride = "Belarussian Collaborator 11",
                    CategoryOverride = ModAPI.FindCategory("BKA"),
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none.png"),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Outfit/Belarussian Collaborator 11.png");
						var flesh = ModAPI.LoadTexture("flesh.png");
						var bone = ModAPI.LoadTexture("bone.png");
                        Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, flesh, bone);

                        //get person
                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin, flesh, bone, 12);
                    }
                }
            );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Belarussian Policeman",
                    NameToOrderByOverride = "a",
                    DescriptionOverride = "Belarussian Policeman",
                    CategoryOverride = ModAPI.FindCategory("BKA"),
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none.png"),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Outfit/Belarussian Policeman.png");
						var flesh = ModAPI.LoadTexture("flesh.png");
						var bone = ModAPI.LoadTexture("bone.png");
                        Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, flesh, bone);

                        //get person
                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin, flesh, bone, 12);
                    }
                }
            );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Cadet of the Dalwitz battalion",
                    NameToOrderByOverride = "a",
                    DescriptionOverride = "Cadet of the Dalwitz battalion",
                    CategoryOverride = ModAPI.FindCategory("BKA"),
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none.png"),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Outfit/Cadet of the Dalwitz battalion.png");
						var flesh = ModAPI.LoadTexture("flesh.png");
						var bone = ModAPI.LoadTexture("bone.png");
                        Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, flesh, bone);

                        //get person
                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin, flesh, bone, 12);
                    }
                }
            );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Captain BRD",
                    NameToOrderByOverride = "a",
                    DescriptionOverride = "Captain BRD",
                    CategoryOverride = ModAPI.FindCategory("BKA"),
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none.png"),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Outfit/Captain BRD.png");
						var flesh = ModAPI.LoadTexture("flesh.png");
						var bone = ModAPI.LoadTexture("bone.png");
                        Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, flesh, bone);

                        //get person
                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin, flesh, bone, 12);
                    }
                }
            );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Captain in police uniform",
                    NameToOrderByOverride = "a",
                    DescriptionOverride = "Captain in police uniform",
                    CategoryOverride = ModAPI.FindCategory("BKA"),
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none.png"),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Outfit/Captain in police uniform.png");
						var flesh = ModAPI.LoadTexture("flesh.png");
						var bone = ModAPI.LoadTexture("bone.png");
                        Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, flesh, bone);

                        //get person
                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin, flesh, bone, 12);
                    }
                }
            );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Drummer BRD",
                    NameToOrderByOverride = "a",
                    DescriptionOverride = "Drummer BRD",
                    CategoryOverride = ModAPI.FindCategory("BKA"),
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none.png"),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Outfit/Drummer BRD.png");
						var flesh = ModAPI.LoadTexture("flesh.png");
						var bone = ModAPI.LoadTexture("bone.png");
                        Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, flesh, bone);

                        //get person
                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin, flesh, bone, 12);
                    }
                }
            );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Franz Kuschel",
                    NameToOrderByOverride = "a",
                    DescriptionOverride = "Franz Kuschel",
                    CategoryOverride = ModAPI.FindCategory("BKA"),
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none.png"),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Outfit/Franz Kuschel.png");
						var flesh = ModAPI.LoadTexture("flesh.png");
						var bone = ModAPI.LoadTexture("bone.png");
                        Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, flesh, bone);

                        //get person
                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin, flesh, bone, 12);
                    }
                }
            );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Gauptsharfuhrer 1st Grenadier brigads SS",
                    NameToOrderByOverride = "a",
                    DescriptionOverride = "Gauptsharfuhrer 1st Grenadier brigads SS",
                    CategoryOverride = ModAPI.FindCategory("BKA"),
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none.png"),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Outfit/Gauptsharfuhrer 1st Grenadier brigads SS.png");
						var flesh = ModAPI.LoadTexture("flesh.png");
						var bone = ModAPI.LoadTexture("bone.png");
                        Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, flesh, bone);

                        //get person
                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin, flesh, bone, 12);
                    }
                }
            );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Ivan Gelda (1943-1944)",
                    NameToOrderByOverride = "a",
                    DescriptionOverride = "Ivan Gelda (1943-1944)",
                    CategoryOverride = ModAPI.FindCategory("BKA"),
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none.png"),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Outfit/Ivan Gelda 1943-1944.png");
						var flesh = ModAPI.LoadTexture("flesh.png");
						var bone = ModAPI.LoadTexture("bone.png");
                        Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, flesh, bone);

                        //get person
                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin, flesh, bone, 12);
                    }
                }
            );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Ivan Gelda",
                    NameToOrderByOverride = "a",
                    DescriptionOverride = "Ivan Gelda",
                    CategoryOverride = ModAPI.FindCategory("BKA"),
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none.png"),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Outfit/Ivan Gelda.png");
						var flesh = ModAPI.LoadTexture("flesh.png");
						var bone = ModAPI.LoadTexture("bone.png");
                        Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, flesh, bone);

                        //get person
                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin, flesh, bone, 12);
                    }
                }
            );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Major BRD",
                    NameToOrderByOverride = "a",
                    DescriptionOverride = "Major BRD",
                    CategoryOverride = ModAPI.FindCategory("BKA"),
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none.png"),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Outfit/Major BRD.png");
						var flesh = ModAPI.LoadTexture("flesh.png");
						var bone = ModAPI.LoadTexture("bone.png");
                        Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, flesh, bone);

                        //get person
                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin, flesh, bone, 12);
                    }
                }
            );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Member UBY",
                    NameToOrderByOverride = "a",
                    DescriptionOverride = "Member UBY",
                    CategoryOverride = ModAPI.FindCategory("BKA"),
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none.png"),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Outfit/Member UBY.png");
						var flesh = ModAPI.LoadTexture("flesh.png");
						var bone = ModAPI.LoadTexture("bone.png");
                        Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, flesh, bone);

                        //get person
                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin, flesh, bone, 12);
                    }
                }
            );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Member UBY 2",
                    NameToOrderByOverride = "a",
                    DescriptionOverride = "Member UBY 2",
                    CategoryOverride = ModAPI.FindCategory("BKA"),
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none.png"),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Outfit/Member UBY 2.png");
						var flesh = ModAPI.LoadTexture("flesh.png");
						var bone = ModAPI.LoadTexture("bone.png");
                        Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, flesh, bone);

                        //get person
                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin, flesh, bone, 12);
                    }
                }
            );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Member UBY 3",
                    NameToOrderByOverride = "a",
                    DescriptionOverride = "Member UBY 3",
                    CategoryOverride = ModAPI.FindCategory("BKA"),
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none.png"),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Outfit/Member UBY 3.png");
						var flesh = ModAPI.LoadTexture("flesh.png");
						var bone = ModAPI.LoadTexture("bone.png");
                        Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, flesh, bone);

                        //get person
                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin, flesh, bone, 12);
                    }
                }
            );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Officer 1st Grenadier brigads SS",
                    NameToOrderByOverride = "a",
                    DescriptionOverride = "Officer 1st Grenadier brigads SS",
                    CategoryOverride = ModAPI.FindCategory("BKA"),
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none.png"),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Outfit/Officer 1st Grenadier brigads SS.png");
						var flesh = ModAPI.LoadTexture("flesh.png");
						var bone = ModAPI.LoadTexture("bone.png");
                        Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, flesh, bone);

                        //get person
                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin, flesh, bone, 12);
                    }
                }
            );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Officer of the Dalwitz battalion",
                    NameToOrderByOverride = "a",
                    DescriptionOverride = "Officer of the Dalwitz battalion",
                    CategoryOverride = ModAPI.FindCategory("BKA"),
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none.png"),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Outfit/Officer of the Dalwitz battalion.png");
						var flesh = ModAPI.LoadTexture("flesh.png");
						var bone = ModAPI.LoadTexture("bone.png");
                        Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, flesh, bone);

                        //get person
                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin, flesh, bone, 12);
                    }
                }
            );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Saboteur in the uniform of a Red Army foreman",
                    NameToOrderByOverride = "a",
                    DescriptionOverride = "Saboteur in the uniform of a Red Army foreman",
                    CategoryOverride = ModAPI.FindCategory("BKA"),
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none.png"),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Outfit/Saboteur in the uniform of a Red Army foreman.png");
						var flesh = ModAPI.LoadTexture("flesh.png");
						var bone = ModAPI.LoadTexture("bone.png");
                        Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, flesh, bone);

                        //get person
                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin, flesh, bone, 12);
                    }
                }
            );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Sagittarius 1st Grenadier brigads SS",
                    NameToOrderByOverride = "a",
                    DescriptionOverride = "Sagittarius 1st Grenadier brigads SS",
                    CategoryOverride = ModAPI.FindCategory("BKA"),
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none.png"),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Outfit/Sagittarius 1st Grenadier brigads SS.png");
						var flesh = ModAPI.LoadTexture("flesh.png");
						var bone = ModAPI.LoadTexture("bone.png");
                        Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, flesh, bone);

                        //get person
                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin, flesh, bone, 12);
                    }
                }
            );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Sagittarius BRD",
                    NameToOrderByOverride = "a",
                    DescriptionOverride = "Sagittarius BRD",
                    CategoryOverride = ModAPI.FindCategory("BKA"),
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none.png"),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Outfit/Sagittarius BRD.png");
						var flesh = ModAPI.LoadTexture("flesh.png");
						var bone = ModAPI.LoadTexture("bone.png");
                        Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, flesh, bone);

                        //get person
                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin, flesh, bone, 12);
                    }
                }
            );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Sagittarius in 13th battalion Minsks SD uniform",
                    NameToOrderByOverride = "a",
                    DescriptionOverride = "Sagittarius in 13th battalion Minsks SD uniform",
                    CategoryOverride = ModAPI.FindCategory("BKA"),
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none.png"),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Outfit/Sagittarius in 13th battalion Minsks SD uniform.png");
						var flesh = ModAPI.LoadTexture("flesh.png");
						var bone = ModAPI.LoadTexture("bone.png");
                        Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, flesh, bone);

                        //get person
                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin, flesh, bone, 12);
                    }
                }
            );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Sagittarius in German police uniform",
                    NameToOrderByOverride = "a",
                    DescriptionOverride = "Sagittarius in German police uniform",
                    CategoryOverride = ModAPI.FindCategory("BKA"),
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none.png"),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Outfit/Sagittarius in German police uniform.png");
						var flesh = ModAPI.LoadTexture("flesh.png");
						var bone = ModAPI.LoadTexture("bone.png");
                        Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, flesh, bone);

                        //get person
                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin, flesh, bone, 12);
                    }
                }
            );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Sagittarius in the form of the Todt organization",
                    NameToOrderByOverride = "a",
                    DescriptionOverride = "Sagittarius in the form of the Todt organization",
                    CategoryOverride = ModAPI.FindCategory("BKA"),
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none.png"),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Outfit/Sagittarius in the form of the Todt organization.png");
						var flesh = ModAPI.LoadTexture("flesh.png");
						var bone = ModAPI.LoadTexture("bone.png");
                        Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, flesh, bone);

                        //get person
                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin, flesh, bone, 12);
                    }
                }
            );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Senior sagittarius BRD",
                    NameToOrderByOverride = "a",
                    DescriptionOverride = "Senior sagittarius BRD",
                    CategoryOverride = ModAPI.FindCategory("BKA"),
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none.png"),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Outfit/Senior sagittarius BRD.png");
						var flesh = ModAPI.LoadTexture("flesh.png");
						var bone = ModAPI.LoadTexture("bone.png");
                        Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, flesh, bone);

                        //get person
                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin, flesh, bone, 12);
                    }
                }
            );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Sergeant major of the saper battalion",
                    NameToOrderByOverride = "a",
                    DescriptionOverride = "Sergeant major of the saper battalion",
                    CategoryOverride = ModAPI.FindCategory("BKA"),
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none.png"),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Outfit/Sergeant major of the saper battalion.png");
						var flesh = ModAPI.LoadTexture("flesh.png");
						var bone = ModAPI.LoadTexture("bone.png");
                        Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, flesh, bone);

                        //get person
                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin, flesh, bone, 12);
                    }
                }
            );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Soldat 1st Grenadier brigads SS",
                    NameToOrderByOverride = "a",
                    DescriptionOverride = "Soldat 1st Grenadier brigads SS",
                    CategoryOverride = ModAPI.FindCategory("BKA"),
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none.png"),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Outfit/Soldat 1st Grenadier brigads SS.png");
						var flesh = ModAPI.LoadTexture("flesh.png");
						var bone = ModAPI.LoadTexture("bone.png");
                        Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, flesh, bone);

                        //get person
                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin, flesh, bone, 12);
                    }
                }
            );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Standard Bearer BRD",
                    NameToOrderByOverride = "a",
                    DescriptionOverride = "Standard Bearer BRD",
                    CategoryOverride = ModAPI.FindCategory("BKA"),
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none.png"),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Outfit/Standard Bearer BRD.png");
						var flesh = ModAPI.LoadTexture("flesh.png");
						var bone = ModAPI.LoadTexture("bone.png");
                        Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, flesh, bone);

                        //get person
                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin, flesh, bone, 12);
                    }
                }
            );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Untersharfuhrer 1st Grenadier brigads SS",
                    NameToOrderByOverride = "a",
                    DescriptionOverride = "Untersharfuhrer 1st Grenadier brigads SS",
                    CategoryOverride = ModAPI.FindCategory("BKA"),
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none.png"),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Outfit/Untersharfuhrer 1st Grenadier brigads SS.png");
						var flesh = ModAPI.LoadTexture("flesh.png");
						var bone = ModAPI.LoadTexture("bone.png");
                        Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, flesh, bone);

                        //get person
                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin, flesh, bone, 12);
                    }
                }
            );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Human"),
                    NameOverride = "Vice Corporal of the Belarusian Auxiliary Police",
                    NameToOrderByOverride = "a",
                    DescriptionOverride = "Vice Corporal of the Belarusian Auxiliary Police",
                    CategoryOverride = ModAPI.FindCategory("BKA"),
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none.png"),
                    AfterSpawn = (Instance) =>
                    {
                        var skin = ModAPI.LoadTexture("Outfit/Vice Corporal of the Belarusian Auxiliary Police.png");
						var flesh = ModAPI.LoadTexture("flesh.png");
						var bone = ModAPI.LoadTexture("bone.png");
                        Instance.GetComponent<PersonBehaviour>().SetBodyTextures(skin, flesh, bone);

                        //get person
                        var person = Instance.GetComponent<PersonBehaviour>();
                        person.SetBodyTextures(skin, flesh, bone, 12);
                    }
                }
            );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "M42 1st Grenadier brigads SS helmet", 
                     NameToOrderByOverride = "h",
                    DescriptionOverride = "M42 1st Grenadier brigads SS helmet", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none1.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Headgear/M42 1st Grenadier brigads SS helmet.png", 76f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "Head";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("Headgear/M42 1st Grenadier brigads SS helmet.png", 76f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "M42 helmet", 
                    NameToOrderByOverride = "i",
                    DescriptionOverride = "M42 helmet", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none1.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Headgear/M42 helmet.png", 76f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "Head";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("Headgear/M42 helmet.png", 76f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "M43 Air defense assistant UBY cap", 
                    NameToOrderByOverride = "j",
                    DescriptionOverride = "M43 Air defense assistant UBY cap", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none1.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Headgear/M43 Air defense assistant UBY cap.png", 79f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "Head";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("Headgear/M43 Air defense assistant UBY cap.png", 79f);
                        prop.armorPoints = 10;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "M43 Battalion Instructor Dalwitz cap", 
                    NameToOrderByOverride = "j",
                    DescriptionOverride = "M43 Battalion Instructor Dalwitz cap", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none1.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Headgear/M43 Battalion Instructor Dalwitz cap.png", 79f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "Head";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("Headgear/M43 Battalion Instructor Dalwitz cap.png", 79f);
                        prop.armorPoints = 10;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "M43 Battalion Instructor Dalwitz cap", 
                    NameToOrderByOverride = "j",
                    DescriptionOverride = "M43 Air defense assistant-SS trainee UBY cap", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none1.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Headgear/M43 Air defense assistant-SS trainee UBY cap.png", 79f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "Head";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("Headgear/M43 Air defense assistant-SS trainee UBY cap.png", 79f);
                        prop.armorPoints = 10;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "M43 Belarussian Policeman cap", 
                    NameToOrderByOverride = "j",
                    DescriptionOverride = "M43 Belarussian Policeman cap", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none1.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Headgear/M43 Belarussian Policeman cap.png", 79f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "Head";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("Headgear/M43 Belarussian Policeman cap.png", 79f);
                        prop.armorPoints = 10;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "M43 BRD cap", 
                    NameToOrderByOverride = "j",
                    DescriptionOverride = "M43 BRD cap", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none1.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Headgear/M43 BRD cap.png", 79f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "Head";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("Headgear/M43 BRD cap.png", 79f);
                        prop.armorPoints = 10;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "M43 Captain BRD cap", 
                    NameToOrderByOverride = "j",
                    DescriptionOverride = "M43 Captain BRD cap", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none1.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Headgear/M43 Captain BRD cap.png", 79f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "Head";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("Headgear/M43 Captain BRD cap.png", 79f);
                        prop.armorPoints = 10;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "M43 Captain in police cap", 
                    NameToOrderByOverride = "j",
                    DescriptionOverride = "M43 Captain in police cap", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none1.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Headgear/M43 Captain in police cap.png", 79f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "Head";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("Headgear/M43 Captain in police cap.png", 79f);
                        prop.armorPoints = 10;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "M43 Gauptsharfuhrer 1st Grenadier brigads SS cap", 
                    NameToOrderByOverride = "j",
                    DescriptionOverride = "M43 Gauptsharfuhrer 1st Grenadier brigads SS cap", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none1.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Headgear/M43 Gauptsharfuhrer 1st Grenadier brigads SS cap.png", 79f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "Head";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("Headgear/M43 Gauptsharfuhrer 1st Grenadier brigads SS cap.png", 79f);
                        prop.armorPoints = 10;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "M43 UBY cap 2", 
                    NameToOrderByOverride = "j",
                    DescriptionOverride = "M43 UBY cap 2", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none1.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Headgear/M43 UBY cap 2.png", 79f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "Head";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("Headgear/M43 UBY cap 2.png", 79f);
                        prop.armorPoints = 10;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "M43 UBY cap", 
                    NameToOrderByOverride = "j",
                    DescriptionOverride = "M43 UBY cap", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none1.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Headgear/M43 UBY cap.png", 79f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "Head";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("Headgear/M43 UBY cap.png", 79f);
                        prop.armorPoints = 10;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "Ivan Gelda 1943-1944 cap", 
                    NameToOrderByOverride = "j",
                    DescriptionOverride = "Ivan Gelda 1943-1944 cap", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none1.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Headgear/Ivan Gelda 1943-1944 cap.png", 79f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "Head";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("Headgear/Ivan Gelda 1943-1944 cap.png", 79f);
                        prop.armorPoints = 10;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "Ivan Gelda cap", 
                    NameToOrderByOverride = "j",
                    DescriptionOverride = "Ivan Gelda cap", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none1.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Headgear/Ivan Gelda cap.png", 79f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "Head";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("Headgear/Ivan Gelda cap.png", 79f);
                        prop.armorPoints = 10;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "M38 13th battalion Minsks SD cap", 
                    NameToOrderByOverride = "k",
                    DescriptionOverride = "M38 13th battalion Minsks SD cap", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none1.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Headgear/M38 13th battalion Minsks SD cap.png", 66f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "Head";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("Headgear/M38 13th battalion Minsks SD cap.png", 66f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "M38 BRD cap", 
                    NameToOrderByOverride = "k",
                    DescriptionOverride = "M38 BRD cap", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none1.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Headgear/M38 BRD cap.png", 66f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "Head";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("Headgear/M38 BRD cap.png", 66f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "M38 BRD cap 2", 
                    NameToOrderByOverride = "k",
                    DescriptionOverride = "M38 BRD cap 2", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none1.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Headgear/M38 BRD cap 2.png", 66f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "Head";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("Headgear/M38 BRD cap 2.png", 66f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "M38 German police cap", 
                    NameToOrderByOverride = "k",
                    DescriptionOverride = "M38 German police cap", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none1.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Headgear/M38 German police cap.png", 66f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "Head";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("Headgear/M38 German police cap.png", 66f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "M38 Soldat 1st Grenadier brigads SS cap", 
                    NameToOrderByOverride = "k",
                    DescriptionOverride = "M38 Soldat 1st Grenadier brigads SS cap", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none1.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Headgear/M38 Soldat 1st Grenadier brigads SS cap.png", 66f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "Head";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("Headgear/M38 Soldat 1st Grenadier brigads SS cap.png", 66f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "M38 the Dalwitz battalion cap", 
                    NameToOrderByOverride = "k",
                    DescriptionOverride = "M38 the Dalwitz battalion cap", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none1.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Headgear/M38 the Dalwitz battalion cap.png", 66f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "Head";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("Headgear/M38 the Dalwitz battalion cap.png", 66f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "M38 the Todt organization cap", 
                    NameToOrderByOverride = "k",
                    DescriptionOverride = "M38 the Todt organization cap", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none1.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Headgear/M38 the Todt organization cap.png", 66f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "Head";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("Headgear/M38 the Todt organization cap.png", 66f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "M38 UBY cap", 
                    NameToOrderByOverride = "k",
                    DescriptionOverride = "M38 UBY cap", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none1.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Headgear/M38 UBY cap.png", 66f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "Head";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("Headgear/M38 UBY cap.png", 66f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "M38 Untersharfuhrer 1st Grenadier brigads SS cap", 
                    NameToOrderByOverride = "k",
                    DescriptionOverride = "M38 Untersharfuhrer 1st Grenadier brigads SS cap", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none1.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Headgear/M38 Untersharfuhrer 1st Grenadier brigads SS cap.png", 66f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "Head";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("Headgear/M38 Untersharfuhrer 1st Grenadier brigads SS cap.png", 66f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "M38 Vice Corporal of the Belarusian Auxiliary Police cap", 
                    NameToOrderByOverride = "k",
                    DescriptionOverride = "M38 Vice Corporal of the Belarusian Auxiliary Police cap", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none1.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Headgear/M38 Vice Corporal of the Belarusian Auxiliary Police cap.png", 66f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "Head";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("Headgear/M38 Vice Corporal of the Belarusian Auxiliary Police cap.png", 66f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "1st Grenadier brigads SS Officer cap", 
                    NameToOrderByOverride = "m",
                    DescriptionOverride = "1st Grenadier brigads SS Officer cap", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none1.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Headgear/1st Grenadier brigads SS Officer cap.png", 21f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "Head";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("Headgear/1st Grenadier brigads SS Officer cap.png", 21f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "Franz Kuschel cap", 
                    NameToOrderByOverride = "m",
                    DescriptionOverride = "Franz Kuschel cap", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none1.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Headgear/Franz Kuschel cap.png", 21f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "Head";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("Headgear/Franz Kuschel cap.png", 21f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "The Dalwitz battalion Officer cap", 
                    NameToOrderByOverride = "m",
                    DescriptionOverride = "FThe Dalwitz battalion Officer cap", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none1.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Headgear/The Dalwitz battalion Officer cap.png", 21f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "Head";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("Headgear/The Dalwitz battalion Officer cap.png", 21f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "BRD ushanka", 
                    NameToOrderByOverride = "o",
                    DescriptionOverride = "BRD ushanka", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none2.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Headgear/BRD ushanka.png", 70f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "Head";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("Headgear/BRD ushanka.png", 70f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "Ushanka opened", 
                    NameToOrderByOverride = "o",
                    DescriptionOverride = "Ushanka", 
                    CategoryOverride = ModAPI.FindCategory(""), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none1.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Headgear/Ushanka.png", 70f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "Head";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("Headgear/Ushanka.png", 70f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "Ushanka", 
                    NameToOrderByOverride = "o",
                    DescriptionOverride = "Ushanka opened", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none2.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Headgear/Ushanka opened.png", 70f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "Head";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("Headgear/Ushanka opened.png", 70f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "Ushanka opened 2", 
                    NameToOrderByOverride = "o",
                    DescriptionOverride = "Ushanka 2", 
                    CategoryOverride = ModAPI.FindCategory(""), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none1.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Headgear/Ushanka 2.png", 70f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "Head";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("Headgear/Ushanka 2.png", 70f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "Ushanka 2", 
                    NameToOrderByOverride = "o",
                    DescriptionOverride = "Ushanka opened 2", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none2.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Headgear/Ushanka opened 2.png", 70f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "Head";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("Headgear/Ushanka opened 2.png", 70f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "Ushanka opened 3", 
                    NameToOrderByOverride = "o",
                    DescriptionOverride = "Ushanka 3", 
                    CategoryOverride = ModAPI.FindCategory(""), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none1.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Headgear/Ushanka 3.png", 70f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "Head";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("Headgear/Ushanka 3.png", 70f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "Ushanka 3", 
                    NameToOrderByOverride = "o",
                    DescriptionOverride = "Ushanka opened 3", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none2.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Headgear/Ushanka opened 3.png", 70f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "Head";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("Headgear/Ushanka opened 3.png", 70f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "Civil cap 1", 
                    NameToOrderByOverride = "w",
                    DescriptionOverride = "Civil cap 1", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none2.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Headgear/Civil cap 1.png", 150f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "Head";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("Headgear/Civil cap 1.png", 150f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "Civil cap 2", 
                    NameToOrderByOverride = "w",
                    DescriptionOverride = "Civil cap 2", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none2.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Headgear/Civil cap 2.png", 60f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "Head";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("Headgear/Civil cap 2.png", 60f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "Civil cap 3", 
                    NameToOrderByOverride = "w",
                    DescriptionOverride = "Civil cap 3", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none2.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Headgear/Civil cap 3.png", 70f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "Head";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("Headgear/Civil cap 3.png", 70f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "Civil cap 4", 
                    NameToOrderByOverride = "w",
                    DescriptionOverride = "Civil cap 4", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none2.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Headgear/Civil cap 4.png", 50f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "Head";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("Headgear/Civil cap 4.png", 50f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "Civil cap 5", 
                    NameToOrderByOverride = "w",
                    DescriptionOverride = "Civil cap 5", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none2.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Headgear/Civil cap 5.png", 32f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "Head";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("Headgear/Civil cap 5.png", 32f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "Civil cap 6", 
                    NameToOrderByOverride = "w",
                    DescriptionOverride = "Civil cap 6", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none2.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Headgear/Civil cap 6.png", 47f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "Head";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("Headgear/Civil cap 6.png", 47f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "Soviet pilotka", 
                    NameToOrderByOverride = "m",
                    DescriptionOverride = "Soviet pilotka", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none1.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("Headgear/soviet pilotka.png", 12f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "Head";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("Headgear/soviet pilotka.png", 12f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
 ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Stick"),
                    NameOverride = "Belarussian Flag",
                    NameToOrderByOverride = "y",
                    DescriptionOverride = "Belarussian Flag",
                    CategoryOverride = ModAPI.FindCategory("BKA"),
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none3.png", 1f),
                    AfterSpawn = (Instance) =>
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("flags/Belarussian Flag.png", 5f);
                        Instance.FixColliders();

                    }
                }
            );
 ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Stick"),
                    NameOverride = "Belarussian Flag 2",
                    NameToOrderByOverride = "z",
                    DescriptionOverride = "Belarussian Flag 2",
                    CategoryOverride = ModAPI.FindCategory("BKA"),
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none3.png", 1f),
                    AfterSpawn = (Instance) =>
                    {
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("flags/Belarussian Flag 2.png", 4f);
                        Instance.FixColliders();

                    }
                }
            );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "Belarussian armband", 
                    NameToOrderByOverride = "z1",
                    DescriptionOverride = "Belarussian armband", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none4.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("armband/Belarussian armband.png", 12f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "UpperArmFront";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("armband/Belarussian armband.png", 12f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "BPSh armband", 
                    NameToOrderByOverride = "z1",
                    DescriptionOverride = "BPSh armband", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none4.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("armband/BPSh armband.png", 12f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "UpperArmFront";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("armband/BPSh armband.png", 12f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "Police armband", 
                    NameToOrderByOverride = "z1",
                    DescriptionOverride = "Police armband", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none4.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("armband/Police armband.png", 12f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "UpperArmFront";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("armband/Police armband.png", 12f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "UBY armband", 
                    NameToOrderByOverride = "z1",
                    DescriptionOverride = "UBY armband", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none4.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("armband/UBY armband.png", 12f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "UpperArmFront";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("armband/UBY armband.png", 12f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "UBY armband", 
                    NameToOrderByOverride = "z1",
                    DescriptionOverride = "UBY armband", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none4.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("armband/UBY armband.png", 12f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "UpperArmFront";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("armband/UBY armband.png", 12f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "UBY armband 2", 
                    NameToOrderByOverride = "z1",
                    DescriptionOverride = "UBY armband 2", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none4.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("armband/UBY armband 2.png", 12f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "UpperArmFront";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("armband/UBY armband 2.png", 12f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "UBY armband 3", 
                    NameToOrderByOverride = "z1",
                    DescriptionOverride = "UBY armband 3", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none4.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("armband/UBY armband 3.png", 120f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "UpperArmFront";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("armband/UBY armband 3.png", 120f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "Shewron belarus ss", 
                    NameToOrderByOverride = "z1",
                    DescriptionOverride = "Shewron belarus ss", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none4.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("armband/shewron belarus ss.png", 200f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "UpperArmFront";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("armband/shewron belarus ss.png", 200f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "Patch UBY", 
                    NameToOrderByOverride = "z1",
                    DescriptionOverride = "Patch UBY", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none4.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("armband/patch UBY.png", 180f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "UpperArmFront";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("armband/patch UBY.png", 180f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "30th SS Volunteer Infantry Division patch", 
                    NameToOrderByOverride = "z1",
                    DescriptionOverride = "30th SS Volunteer Infantry Division patch", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none4.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("armband/30th SS Volunteer Infantry Division (1st Belarusian) patch.png", 200f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "UpperArmFront";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("armband/30th SS Volunteer Infantry Division (1st Belarusian) patch.png", 200f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "Sleeve badge UBY 1", 
                    NameToOrderByOverride = "z1",
                    DescriptionOverride = "Sleeve badge UBY 1", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none4.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("armband/Sleeve badge UBY 1.png", 200f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "UpperArmFront";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("armband/Sleeve badge UBY 1.png", 200f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "Sleeve badge UBY 2", 
                    NameToOrderByOverride = "z1",
                    DescriptionOverride = "Sleeve badge UBY 2", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none4.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("armband/Sleeve badge UBY 2.png", 200f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "UpperArmFront";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("armband/Sleeve badge UBY 2.png", 200f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "Sleeve badge UBY 3", 
                    NameToOrderByOverride = "z1",
                    DescriptionOverride = "Sleeve badge UBY 3", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none4.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("armband/Sleeve badge UBY 3.png", 200f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "UpperArmFront";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("armband/Sleeve badge UBY 3.png", 200f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "Sleeve badge assistant-SS UBY", 
                    NameToOrderByOverride = "z1",
                    DescriptionOverride = "Sleeve badge assistant-SS UBY", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none4.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("armband/Sleeve badge assistant-SS UBY.png", 200f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "UpperArmFront";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("armband/Sleeve badge assistant-SS UBY.png", 200f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "Shewron BRD", 
                    NameToOrderByOverride = "z1",
                    DescriptionOverride = "Shewron BRD", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none4.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("armband/shewron BRD.png", 215f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "UpperArmFront";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("armband/shewron BRD.png", 215f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "Shewron BRD 2", 
                    NameToOrderByOverride = "z1",
                    DescriptionOverride = "Shewron BRD 2", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none4.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("armband/shewron BRD 2.png", 215f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "UpperArmFront";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("armband/shewron BRD 2.png", 215f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "Shewron BRD 3", 
                    NameToOrderByOverride = "z1",
                    DescriptionOverride = "Shewron BRD 3", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none4.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("armband/shewron BRD 3.png", 200f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "UpperArmFront";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("armband/shewron BRD 3.png", 200f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "Weissruthenien patch", 
                    NameToOrderByOverride = "z1",
                    DescriptionOverride = "Weissruthenien patch", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none4.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("armband/weissruthenien.png", 200f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "UpperArmFront";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("armband/weissruthenien.png", 200f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "Sleeve badge BRD", 
                    NameToOrderByOverride = "z1",
                    DescriptionOverride = "Sleeve badge BRD", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none4.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("armband/sleeve badge BRD.png", 12f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "UpperArmFront";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("armband/sleeve badge BRD.png", 12f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "SBM patch", 
                    NameToOrderByOverride = "z1",
                    DescriptionOverride = "SBM patch", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none4.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("armband/SBM.png", 315f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "UpperArmFront";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("armband/SBM.png", 315f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "Drummer BRD coat", 
                    NameToOrderByOverride = "z2",
                    DescriptionOverride = "Drummer BRD coat", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none5.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("coat/Drummer BRD coat.png", 12f);  
                        int PartCount = 1;
                        Instance.GetComponent<SpriteRenderer>().sortingLayerName = "UpperBody";
                        Instance.layer = 20;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "LowerBody";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("coat/Drummer BRD coat.png", 12f);
                        prop.armorPoints = 1;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );
ModAPI.Register(
                new Modification()
                {
                    OriginalItem = ModAPI.FindSpawnable("Bowling Pin"), 
                    NameOverride = "Sagittarius 1st Grenadier brigads SS coat", 
                    NameToOrderByOverride = "z2",
                    DescriptionOverride = "Sagittarius 1st Grenadier brigads SS coat", 
                    CategoryOverride = ModAPI.FindCategory("BKA"), 
                    ThumbnailOverride = ModAPI.LoadSprite("Icon/none5.png"), 
                    AfterSpawn = (Instance) => 
                    {   
                        Instance.GetComponent<SpriteRenderer>().sprite = ModAPI.LoadSprite("coat/Sagittarius 1st Grenadier brigads SS coat.png", 12f);  
                        int PartCount = 1;
                        Instance.GetOrAddComponent<ArmorBehaviour>();
                        Instance.GetComponent<SpriteRenderer>().sortingLayerName = "MiddleBody";
                        Instance.layer = 16;
                        ArmorBehaviour armor = Instance.GetComponent<ArmorBehaviour>();
                        ArmorProperties prop = new ArmorProperties();
                        prop.armorPiece = "LowerBody";
                        prop.armorTier = 3;
                        prop.sprite = ModAPI.LoadSprite("coat/Sagittarius 1st Grenadier brigads SS coat.png", 12f);
                        prop.armorPoints = 300;
                        prop.offset = new Vector2(0f, 2f) * ModAPI.PixelSize;
                        armor.prop = prop;
                        armor.SetProperties();

                        if (armor.spawn)
                        {
                            armor.SetPieces = new ArmorBehaviour[PartCount - 1];
                        }
                        Instance.FixColliders();
                    }
                }
          );



}












public class MultipleSpriteHumanBehaviour : MonoBehaviour
    {
        public Texture2D[] Textures = new Texture2D[0];
        public PersonBehaviour person;
        public int CurrentTexture = -2;
        public int Scale = 3;

        void Start()
        {
            SetTexture();
        }

        public void SetTexture()
        {
            if (Textures.Length == 0)
                return;

            if(CurrentTexture == -2)
            {
                CurrentTexture = UnityEngine.Random.Range(0, Textures.Length);
            }
            person.SetBodyTextures(Textures[CurrentTexture], null, null, Scale);
            for (int i = 0; i < person.Limbs.Length; i++)
            {
                person.Limbs[i].gameObject.GetComponent<PhysicalBehaviour>().RefreshOutline();
            }
        }
}    }
}
