import 'package:json_annotation/json_annotation.dart';

part 'PersonalDetails.g.dart';

@JsonSerializable()
class PersonalDetails{
  int id;
  String name;
  String surname;
  String personalCode;
  DateTime birthDate;

  PersonalDetails(this.id, this.name, this.surname, this.personalCode, this.birthDate);

  factory PersonalDetails.fromJson(Map<String, dynamic> json) => _$PersonalDetailsFromJson(json);

  Map<String, dynamic> toJson() => _$PersonalDetailsToJson(this);

}