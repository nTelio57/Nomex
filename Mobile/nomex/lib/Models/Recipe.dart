import 'package:json_annotation/json_annotation.dart';

import 'Medicine.dart';
import 'Usage.dart';

part 'Recipe.g.dart';

@JsonSerializable()
class Recipe{

  int? id;
  DateTime? validUntil;
  Usage? usage;
  Medicine? medicine;

  Recipe(this.id);

  factory Recipe.fromJson(Map<String, dynamic> json) => _$RecipeFromJson(json);

  Map<String, dynamic> toJson() => _$RecipeToJson(this);

}