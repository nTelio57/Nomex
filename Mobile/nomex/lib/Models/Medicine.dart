import 'package:json_annotation/json_annotation.dart';
import 'package:nomex/Models/Usage.dart';

part 'Medicine.g.dart';

@JsonSerializable()
class Medicine{

  int? id;
  String? name;

  Medicine(this.id);

  factory Medicine.fromJson(Map<String, dynamic> json) => _$MedicineFromJson(json);

  Map<String, dynamic> toJson() => _$MedicineToJson(this);

}