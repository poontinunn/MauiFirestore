using System;
using Google.Cloud.Firestore;

namespace MauiFirestore.Models;

public class StudentModel
{
    [FirestoreProperty]
    public string Id { get; set; }


    [FirestoreProperty]
    public string Code { get; set; }


    [FirestoreProperty]
    public string Name { get; set; }




}
