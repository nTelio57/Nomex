import 'package:json_annotation/json_annotation.dart';

part 'Usage.g.dart';

@JsonSerializable()
class Usage{

  int? id;
  String? description;
  Dosage? dosage;

  Usage(this.id);

  factory Usage.fromJson(Map<String, dynamic> json) => _$UsageFromJson(json);

  Map<String, dynamic> toJson() => _$UsageToJson(this);

}

enum Dosage {
@JsonValue(0)
Daily,
@JsonValue(1)
Every2Days,
@JsonValue(2)
Every3Days,
@JsonValue(3)
Every4Days,
@JsonValue(4)
Every5Days,
@JsonValue(5)
OnceAWeek,
@JsonValue(6)
Every2Weeks,
@JsonValue(7)
OnceAMonth
}